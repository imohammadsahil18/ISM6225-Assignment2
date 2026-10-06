// Ask for the current number of customers and convert the input to an integer.
// Console.Write("Enter the current number of customers: ");
// int customerCount = Convert.ToInt32(Console.ReadLine());

// Ask for the monthly price per customer and store it as a decimal value.
// Console.Write("Enter the monthly price per customer: ");
// decimal monthlyPrice = Convert.ToDecimal(Console.ReadLine());

// Ask for the percentage by which the monthly price will increase.
// Console.Write("Enter the percentage price increase: ");
// decimal priceIncreasePercentage = Convert.ToDecimal(Console.ReadLine());

// Multiply the number of customers by the current monthly price.
// decimal currentMonthlyRevenue = customerCount * monthlyPrice;

// Convert the percentage to a multiplier and apply it to current revenue.
// decimal projectedMonthlyRevenue = currentMonthlyRevenue * (1 + priceIncreasePercentage / 100);

// Find the additional monthly revenue after the price increase.
// decimal monthlyRevenueIncrease = projectedMonthlyRevenue - currentMonthlyRevenue;

// Display each revenue amount in currency format with two decimal places.
// Console.WriteLine($"Current monthly revenue: {currentMonthlyRevenue:C2}");
// Console.WriteLine($"Projected monthly revenue: {projectedMonthlyRevenue:C2}");
// Console.WriteLine($"Increase in monthly revenue: {monthlyRevenueIncrease:C2}");

// Question 2: Investment Doubling Time
// Console.Write("Enter the annual return rate as a percentage: ");
// double annualReturnPercentage = Convert.ToDouble(Console.ReadLine());
//
// if (annualReturnPercentage <= 0)
// {
// 	Console.WriteLine("The annual return rate must be greater than zero.");
// }
// else
// {
// 	double rate = annualReturnPercentage / 100;
// 	double doublingTime = Math.Log(2) / Math.Log(1 + rate);
//
// 	Console.WriteLine($"Investment doubling time: {doublingTime:F2} years");
//
// 	if (doublingTime < 10)
// 	{
// 		Console.WriteLine("Classification: Fast");
// 	}
// 	else if (doublingTime <= 20)
// 	{
// 		Console.WriteLine("Classification: Moderate");
// 	}
// 	else
// 	{
// 		Console.WriteLine("Classification: Slow");
// 	}
// }

// Question 3: Delivery Region Triangle
// try
// {
// 	Console.Write("Enter side length a: ");
// 	double a = Convert.ToDouble(Console.ReadLine());
//
// 	Console.Write("Enter side length b: ");
// 	double b = Convert.ToDouble(Console.ReadLine());
//
// 	Console.Write("Enter side length c: ");
// 	double c = Convert.ToDouble(Console.ReadLine());
//
// 	if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
// 	{
// 		double semiPerimeter = (a + b + c) / 2;
// 		double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
//
// 		Console.WriteLine($"Triangle area: {area:F2}");
// 	}
// 	else
// 	{
// 		Console.WriteLine("Error: The side lengths must be positive and satisfy the triangle rule.");
// 	}
// }
// catch (FormatException)
// {
// 	Console.WriteLine("Error: Please enter numeric values for all three side lengths.");
// }

// Question 4: Cloud Usage Invoice
// Console.Write("Enter compute hours: ");
// decimal computeHours = Convert.ToDecimal(Console.ReadLine());
//
// if (computeHours < 0)
// {
// 	Console.WriteLine("Error: Compute hours cannot be negative.");
// }
// else
// {
// 	decimal usageCharge;
//
// 	if (computeHours <= 100)
// 	{
// 		usageCharge = computeHours * 0.12m;
// 	}
// 	else if (computeHours <= 500)
// 	{
// 		usageCharge = (100 * 0.12m) + ((computeHours - 100) * 0.09m);
// 	}
// 	else
// 	{
// 		usageCharge = (100 * 0.12m) + (400 * 0.09m) + ((computeHours - 500) * 0.06m);
// 	}
//
// 	decimal serviceFee = usageCharge * 0.05m;
// 	decimal totalInvoice = usageCharge + serviceFee;
//
// 	Console.WriteLine($"Usage charge: {usageCharge:C2}");
// 	Console.WriteLine($"Service fee: {serviceFee:C2}");
// 	Console.WriteLine($"Total invoice: {totalInvoice:C2}");
// }

// Question 5: Daily Sales Entry with a Sentinel
// decimal saleAmount = 0m;
// decimal totalSales = 0m;
// int validSalesCount = 0;
//
// while (saleAmount != -1)
// {
// 	Console.Write("Enter a sale amount (-1 to finish): ");
// 	saleAmount = Convert.ToDecimal(Console.ReadLine());
//
// 	if (saleAmount == -1)
// 	{
// 		Console.WriteLine("Sales entry finished.");
// 	}
// 	else if (saleAmount < 0)
// 	{
// 		Console.WriteLine("Invalid sale amount. Enter a nonnegative amount or -1 to finish.");
// 	}
// 	else
// 	{
// 		totalSales += saleAmount;
// 		validSalesCount++;
// 	}
// }
//
// if (validSalesCount > 0)
// {
// 	decimal averageSale = totalSales / validSalesCount;
// 	Console.WriteLine($"Valid sales count: {validSalesCount}");
// 	Console.WriteLine($"Total sales: {totalSales:C2}");
// 	Console.WriteLine($"Average sale: {averageSale:C2}");
// }
// else
// {
// 	Console.WriteLine("No valid sales were entered.");
// }

// Question 6: Investment Payback Simulator
// Console.Write("Enter the initial investment: ");
// decimal initialInvestment = Convert.ToDecimal(Console.ReadLine());
//
// Console.Write("Enter the monthly benefit: ");
// decimal monthlyBenefit = Convert.ToDecimal(Console.ReadLine());
//
// if (initialInvestment <= 0 || monthlyBenefit <= 0)
// {
// 	Console.WriteLine("Error: The initial investment and monthly benefit must both be positive.");
// }
// else
// {
// 	decimal cumulativeBenefits = 0m;
// 	int month = 0;
// 	int maximumMonths = 600;
//
// 	while (cumulativeBenefits < initialInvestment && month < maximumMonths)
// 	{
// 		month++;
// 		cumulativeBenefits += monthlyBenefit;
//
// 		decimal unrecoveredBalance = initialInvestment - cumulativeBenefits;
// 		if (unrecoveredBalance < 0)
// 		{
// 			unrecoveredBalance = 0;
// 		}
//
// 		Console.WriteLine($"Month {month}: Unrecovered balance: {unrecoveredBalance:C2}");
// 	}
//
// 	if (cumulativeBenefits >= initialInvestment)
// 	{
// 		Console.WriteLine($"Payback month: {month}");
// 		Console.WriteLine($"Cumulative benefits at payback: {cumulativeBenefits:C2}");
// 	}
// 	else
// 	{
// 		Console.WriteLine($"Investment was not recovered within {maximumMonths} months.");
// 		Console.WriteLine($"Cumulative benefits: {cumulativeBenefits:C2}");
// 	}
// }

// Question 7: Daily Demand Chart
// int[] dailyDemand = new int[7];
//
// for (int day = 0; day < 7; day++)
// {
// 	int demand;
// 	do
// 	{
// 		Console.Write($"Enter demand for day {day + 1}: ");
// 		demand = Convert.ToInt32(Console.ReadLine());
//
// 		if (demand < 0)
// 		{
// 			Console.WriteLine("Demand must be zero or greater. Please try again.");
// 		}
// 	} while (demand < 0);
//
// 	dailyDemand[day] = demand;
// }
//
// for (int day = 0; day < 7; day++)
// {
// 	Console.Write($"Day {day + 1}: Demand {dailyDemand[day]} ");
//
// 	for (int star = 0; star < dailyDemand[day] / 10; star++)
// 	{
// 		Console.Write("*");
// 	}
//
// 	Console.WriteLine();
// }

// Question 8: Risk Score Calculator
// static int ComputeRiskScore(int missedPayments, int supportTickets, int monthsInactive)
// {
// 	int riskScore = (missedPayments * 20) + (supportTickets * 5) + (monthsInactive * 8);
// 	return riskScore;
// }
//
// Console.Write("Enter missed payments: ");
// int missedPayments = Convert.ToInt32(Console.ReadLine());
//
// Console.Write("Enter support tickets: ");
// int supportTickets = Convert.ToInt32(Console.ReadLine());
//
// Console.Write("Enter months inactive: ");
// int monthsInactive = Convert.ToInt32(Console.ReadLine());
//
// if (missedPayments < 0 || supportTickets < 0 || monthsInactive < 0)
// {
// 	Console.WriteLine("Error: All values must be zero or greater.");
// }
// else
// {
// 	int riskScore = ComputeRiskScore(missedPayments, supportTickets, monthsInactive);
// 	string classification;
//
// 	if (riskScore < 30)
// 	{
// 		classification = "Low";
// 	}
// 	else if (riskScore >= 30 && riskScore <= 59)
// 	{
// 		classification = "Moderate";
// 	}
// 	else
// 	{
// 		classification = "High";
// 	}
//
// 	Console.WriteLine($"Risk score: {riskScore}");
// 	Console.WriteLine($"Classification: {classification}");
// }

// Question 9: Transaction Analysis
// Console.Write("How many transaction amounts will be entered? (3 to 20): ");
// int count = Convert.ToInt32(Console.ReadLine());
//
// while (count < 3 || count > 20)
// {
// 	Console.WriteLine("Please enter a number from 3 to 20.");
// 	Console.Write("How many transaction amounts will be entered? (3 to 20): ");
// 	count = Convert.ToInt32(Console.ReadLine());
// }
//
// decimal[] transactions = new decimal[count];
//
// for (int i = 0; i < count; i++)
// {
// 	decimal amount;
//
// 	do
// 	{
// 		Console.Write($"Enter transaction {i + 1}: ");
// 		amount = Convert.ToDecimal(Console.ReadLine());
//
// 		if (amount < 0)
// 		{
// 			Console.WriteLine("Transaction amount cannot be negative. Please try again.");
// 		}
// 	} while (amount < 0);
//
// 	transactions[i] = amount;
// }
//
// decimal minValue = transactions[0];
// decimal maxValue = transactions[0];
// decimal total = 0m;
//
// for (int i = 0; i < count; i++)
// {
// 	if (transactions[i] < minValue)
// 	{
// 		minValue = transactions[i];
// 	}
//
// 	if (transactions[i] > maxValue)
// 	{
// 		maxValue = transactions[i];
// 	}
//
// 	total += transactions[i];
// }
//
// decimal mean = total / count;
//
// Console.WriteLine($"Minimum: {minValue:C2}");
// Console.WriteLine($"Maximum: {maxValue:C2}");
// Console.WriteLine($"Total: {total:C2}");
// Console.WriteLine($"Mean: {mean:C2}");
//
// for (int i = 0; i < count; i++)
// {
// 	string label;
//
// 	if (transactions[i] > mean * 1.5m)
// 	{
// 		label = "Review";
// 	}
// 	else
// 	{
// 		label = "Normal";
// 	}
//
// 	Console.WriteLine($"Transaction {i + 1}: {transactions[i]:C2} - {label}");
// }

// Weekly Sales Analysis
static decimal CalculateTotal(decimal[] sales)
{
	decimal total = 0m;
	for (int i = 0; i < sales.Length; i++)
	{
		total += sales[i];
	}
	return total;
}

static decimal CalculateAverage(decimal[] sales)
{
	decimal total = 0m;
	for (int i = 0; i < sales.Length; i++)
	{
		total += sales[i];
	}
	return total / sales.Length;
}

static decimal CalculateHighest(decimal[] sales)
{
	decimal highest = sales[0];
	for (int i = 1; i < sales.Length; i++)
	{
		if (sales[i] > highest)
		{
			highest = sales[i];
		}
	}
	return highest;
}

static decimal CalculateLowest(decimal[] sales)
{
	decimal lowest = sales[0];
	for (int i = 1; i < sales.Length; i++)
	{
		if (sales[i] < lowest)
		{
			lowest = sales[i];
		}
	}
	return lowest;
}

static int CountAboveAverage(decimal[] sales)
{
	decimal total = 0m;
	for (int i = 0; i < sales.Length; i++)
	{
		total += sales[i];
	}
	decimal average = total / sales.Length;
	int count = 0;
	for (int i = 0; i < sales.Length; i++)
	{
		if (sales[i] > average)
		{
			count++;
		}
	}
	return count;
}

decimal[] salesForWeek = new decimal[7];

for (int i = 0; i < salesForWeek.Length; i++)
{
	while (true)
	{
		try
		{
			Console.Write($"Enter sales for day {i + 1}: ");
			decimal salesValue = Convert.ToDecimal(Console.ReadLine());

			if (salesValue < 0)
			{
				Console.WriteLine("Sales must be zero or greater. Please try again.");
				continue;
			}

			salesForWeek[i] = salesValue;
			break;
		}
		catch (FormatException)
		{
			Console.WriteLine("Please enter a valid number.");
		}
	}
}

Console.WriteLine();
Console.WriteLine("Daily sales values:");
for (int i = 0; i < salesForWeek.Length; i++)
{
	Console.WriteLine($"Day {i + 1}: {salesForWeek[i]:C2}");
}

decimal totalSales = CalculateTotal(salesForWeek);
decimal averageSales = CalculateAverage(salesForWeek);
decimal highestSales = CalculateHighest(salesForWeek);
decimal lowestSales = CalculateLowest(salesForWeek);
int daysAboveAverage = CountAboveAverage(salesForWeek);

Console.WriteLine();
Console.WriteLine($"Total sales: {totalSales:C2}");
Console.WriteLine($"Average sales: {averageSales:C2}");
Console.WriteLine($"Highest sales: {highestSales:C2}");
Console.WriteLine($"Lowest sales: {lowestSales:C2}");
Console.WriteLine($"Number of days above average: {daysAboveAverage}");

if (daysAboveAverage >= 4)
{
	Console.WriteLine("Week classification: Strong");
}
else if (daysAboveAverage >= 2)
{
	Console.WriteLine("Week classification: Balanced");
}
else
{
	Console.WriteLine("Week classification: Concentrated");
}



