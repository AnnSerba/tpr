#include <iostream>
#include <iomanip>
#include <vector>
#include <algorithm>
#include <utility>

using std::cout;
using std::cin;
using std::endl;
using std::pair;


struct SolutionConstraints
{
	//диапазон значений цены
	int priceMin;
	int priceMax;
	int priceStep;
	//диапазон значений пробега
	int usageMin;
	int usageMax;
	int usageStep;
};


typedef std::vector<float> Uvalues;
typedef std::pair<int, int> IPair;
typedef std::pair<float, float> FPair;

int main()
{
	SolutionConstraints constraints;

	cout << "Введите нижний и верхний придел цены и шаг" << endl;
	cin >> constraints.priceMin >> constraints.priceMax >> constraints.priceStep;
	cout << "Введите нижний и верхний придел пробега и шаг" << endl;
	cin >> constraints.usageMin >> constraints.usageMax >> constraints.usageStep;

	//вычисляем значения функции полезности для цены и пробега
	std::vector<int> priceValues;
	std::vector<float> priceCriteriaValues;
	std::vector<int> usageValues;
	std::vector<float> usageCriteriaValues;

	for (int i = constraints.priceMin;i <= constraints.priceMax;i += constraints.priceStep)
	{
		priceValues.push_back(i);
		priceCriteriaValues.push_back(1.0f / i);
	}

	for (int i = constraints.usageMin;i <= constraints.usageMax;i += constraints.usageStep)
	{
		usageValues.push_back(i);
		usageCriteriaValues.push_back(1.0f / i);
	}

	cout << "Значения цены и критерия" << endl;
	for (int i = 0; i < priceValues.size(); ++i)
	{
		cout << priceValues[i] << " " << priceCriteriaValues[i] << endl;
	}

	cout << "Значения пробега и критерия" << endl;
	for (int i = 0; i < usageValues.size(); ++i)
	{
		cout << usageValues[i] << " " << usageCriteriaValues[i] << endl;
	}


	//вычисляем линии безразличия
	std::vector<std::vector<IPair>> lines(priceValues.size());

	for (int level = 0; level < priceValues.size(); ++level)
	for (int j = 0; j < priceValues.size(); ++j)
	for (int i = 0; i < usageValues.size(); ++i)
	if (i + j == level)
		lines[level].push_back(IPair(j, i));

	cout << "Точки с одинаковыми полезностями" << endl;
	{
		int i = 0;
		for (auto it = lines.begin(); it != lines.end(); ++it)
		{
			cout << "Уровень " << it - lines.begin() << endl;
			for (IPair p : *it)
				cout << "( " << p.first << ", " << p.second << " )" << endl;
			++i;
		}
	}


	//аппроксимация одномерных функций полезности
	//цена
	float priceCoeffs[3];
	{
		Eigen::MatrixXf x(priceValues.size(), 3);
		Eigen::VectorXf y(priceValues.size());
		Eigen::Vector3f a;

		for (int iPoint = 0; iPoint < priceValues.size(); ++iPoint)
		{
			float Xi = priceValues[iPoint];
			float Yi = priceValues.size() - 1 - iPoint;

			x(iPoint, 0) = 1;
			x(iPoint, 1) = Xi;
			x(iPoint, 2) = Xi *Xi;

			y(iPoint) = Yi;
		}

		Eigen::MatrixXf tmp = x.transpose().eval() *x;
		a = (tmp.inverse() *x.transpose().eval()) *y;

		for (int i : {0, 1, 2})
			priceCoeffs[i] = a(i);
	}
	//пробег
	float usageCoeffs[3];
	{
		Eigen::MatrixXf x(usageValues.size(), 3);
		Eigen::VectorXf y(usageValues.size());
		Eigen::Vector3f a;

		for (int iPoint = 0; iPoint < usageValues.size(); ++iPoint)
		{
			float Xi = usageValues[iPoint];
			float Yi = usageValues.size() - 1 - iPoint;

			x(iPoint, 0) = 1;
			x(iPoint, 1) = Xi;
			x(iPoint, 2) = Xi *Xi;

			y(iPoint) = Yi;
		}

		a = ((x.transpose() *x).inverse() *x.transpose()) *y;

		for (int i : {0, 1, 2})
			usageCoeffs[i] = a(i);
	}

	cout << "Коэффициенты для полиномма аппроксимации критерия цена" << endl;
	for (auto v : priceCoeffs)
		cout << v << " ";
	cout << endl;

	cout << "Коэффициенты для полиномма аппроксимации критерия пробег" << endl;
	for (auto v : usageCoeffs)
		cout << v << " ";
	cout << endl;

	float scaleCoeff;
	for (const auto &line : lines)
	if (line.size() >1)
	{
		IPair i = line.front();
		IPair j = line.back();

		FPair iCriteriaValues, jCriteriaValues;

		iCriteriaValues.first = priceCriteriaValues[i.first];
		iCriteriaValues.second = usageCriteriaValues[i.second];

		jCriteriaValues.first = priceCriteriaValues[j.first];
		jCriteriaValues.second = usageCriteriaValues[j.second];


		float m = (jCriteriaValues.second - iCriteriaValues.second)
			/ (iCriteriaValues.first - jCriteriaValues.first);

		scaleCoeff = m / (1 + m);
	}

	cout << "коэффициент масштабирования" << endl
		<< scaleCoeff << endl;

	//вычисляем значение многокритериальной функции полезности
	int nCars;
	cout << "Введите количество автомобилей для оценки" << endl;
	cin >> nCars;
	std::vector<FPair> cars;
	cout << "Введите характеристики " << nCars << " автомобилей" << endl;
	for (int i = 0; i < nCars; ++i)
	{
		FPair pair;
		cin >> pair.first >> pair.second;
		cars.push_back(pair);
	}

	std::vector<float> carsUsefullnes;
	for (const FPair &X : cars)
	{
		float U1 = priceCoeffs[0]
			+ priceCoeffs[1] * X.first
			+ priceCoeffs[2] * std::pow(X.first, 2);
		float U2 = usageCoeffs[0]
			+ usageCoeffs[1] * X.second
			+ usageCoeffs[2] * std::pow(X.second, 2);

		float U = scaleCoeff *U1 + (1.0f - scaleCoeff) *U2;
		//float U =U1 + U2;

		carsUsefullnes.push_back(U);
	}

	cout << "Значение функции полезности для машин" << endl;
	for (float v : carsUsefullnes)
		cout << v << endl;

	int iBestCar = 0;
	for (int i = 1; i < cars.size(); ++i)
	if (carsUsefullnes[iBestCar] < carsUsefullnes[i])
		iBestCar = i;

	cout << "Лучшая машина" << endl
		<< "Цена " << cars[iBestCar].first << endl
		<< "Пробег " << cars[iBestCar].second << endl
		<< "Значение критерия " << carsUsefullnes[iBestCar] << endl;


	return 0;
}
