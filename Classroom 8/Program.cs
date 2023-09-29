//static void Test(int num2, string name, int number=100)
//{
//    return num2 + name + number;
//}
//Console.WriteLine(Test(5, "sada");

//static void Test(int a,params int[] arr)
//    int sum = 0;
//    foreach (var item in Arr)
//{
//    sum += item;
//}
//int result = sum * a;
//Console.WriteLine(result);

//Test(1,2,3,4,5);


//using Main;

//Class1.Test(100,5);


//using MethodOverloading;

//int num = 2;

//switch (num)
//{
//    case 2:
//        Class1.Sum();
//        break;
//    case 1:
//        Class1.Sum(15); 
//        break;
//    case 3:
//        Class1.Sum(100,5);
//        break;
//    default:
//        Console.WriteLine("Something is wrong");
//        break;
//}

//int a = 100;
//int b = a;
//b = 200;

//Console.WriteLine(a);
//Console.WriteLine(b);

//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = arr1;
//arr2[0] = 300;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//int[] nums = {2, 3, 4, 5};
//Console.WriteLine(nums[0]);
//Test(nums);
//Console.WriteLine(nums[0]);

//static void Test(int[] arr)
//{
//    arr[0] = 5;
//    Console.WriteLine(arr[0] + 10);
//}

//int b = 20;
//Console.WriteLine(b);
//Test(out b);
//Console.WriteLine(b);

//static void Test(out int a)
//{
//    a = 200;
//    Console.WriteLine(a);
//}


//int a = 5;
//int c = 10;
//int b = ++a;

//a++;
//c = --a;
//Console.WriteLine(b);
//Console.WriteLine(c);

//int[] nums1 = { 2, 3, 4, 5 };
//int a = nums1[0];
//int b = a++;
//int[] nums2 = nums1;
//nums2[0] = a;
//Test(nums2);

//Console.WriteLine(nums1[0]);

//static void Test(int[] arr)
//{
//    arr[0] = 50; 
//}

//string name1 = " Test";
//string name2 = "test";
//Console.WriteLine(name1.ToLower().Trim() == name2.ToLower().Trim());
//Console.WriteLine(name.Length);
//Console.WriteLine(name.ToLower());
//Console.WriteLine(name.ToUpper());
//Console.WriteLine(name1.Trim());

//int a = 5;

//Console.WriteLine(a.ToString().GetType());

//string str = "Azerbaycan";

//Console.WriteLine(str.Replace("A","a"));

//var data = str.ToCharArray();
//Console.WriteLine(data[0]);
//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine(str[i]);
//}
//Console.WriteLine(str.Contains("a"));

//string str1 = "Azerbaycan";
//string str2 = "Respublikasi";

//string result = string.Concat(str1, " ", str2);
//Console.WriteLine(result);

//string str1 = "salam";
//string str2 = "Salam";
//bool result = str2.ToLower().Equals(str2.ToLower());
//Console.WriteLine(result);

//string str1 = "Azerbaycan-gozel respublikadir";
//var result = str1.Split("-");
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//var result = str1.ToCharArray();
//foreach(var item in result)
//{
//    Console.WriteLine(result);
//}

//string str = "test";
//Console.WriteLine(str.StartsWith("t"));
