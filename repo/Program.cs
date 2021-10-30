// Разложите натуральное число n на простые множители и определите

// сколько раз встречается множитель 2 в произведении
// -наименьший множитель произведения
// -сколько различных множителей в произведении

// + 1.1. Натуральное число
// 1.2.1 Что такое простой множитель
// 1.2.2 Что такое разложение на множители
// 1.3. как сделать подсчет нужного множителя


// 2.1. как ввести число типданных n = 12;
// 2.2. как получить разбиение на простые множители
// 2.3. как сделать подсчет нужного множителя


// if(n < 1) Console.WriteLine("Число не натуральное");


int Counter(int n)
{
    int[] simpleNumber = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193 };
    int index = 0;
    int count = 0;
    while (n > 1)
    {
        if (n % simpleNumber[index] == 0)
        {
            //Console.WriteLine(simpleNumber[index]);
            if (simpleNumber[index] == 2)
            {
                count++;
            }
            n = n / simpleNumber[index];
        }
        else
        {
            index++;
        }
    }

    // Console.WriteLine(count);
    return count;
}

int MinCounter(int n)
{
    int [] simplenumber= {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199};
    int index = 0;
    while (n > 1)
    {
        if (n % simplenumber[index] == 0)
        {
            break;
        }
        else
        {
            index++;
        }
    }
    return simplenumber[index];
}

int DiffCounter(int n)
{
    int [] simplenumber= {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199};
    int count = 0;
    bool newcount = true;
    int index = 0;
    while (n > 1)
    {
            if (n % simplenumber[index] == 0)
            {
                n = n / simplenumber[index];
                //Console.WriteLine(simplenumber[index]);
                if (newcount)
                {
                    count = count + 1;
                    newcount = false;
                    //Console.WriteLine(simplenumber[index]);
                }
            }
            else
            {
                newcount = true;
                index++;
            }
    }
    return count;
}


//int n = 32; // 1..2_147_000_000
int result = Counter(24);
Console.WriteLine($"result = {result}");

result = MinCounter(41);
Console.WriteLine($"Минимальный делитель равен: {result}");

result = DiffCounter(637); //7*7*13
Console.WriteLine($"Количество различных множителей составляет: {result}");
