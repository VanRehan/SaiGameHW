using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1();   // In các số từ 1 đến 100
        BaiTap2();   // Tính tổng các số từ 1 đến 50
        BaiTap3();   // In các số chẵn từ 1 đến 100
        BaiTap4();   // Tính tích các số từ 1 đến 10
        BaiTap5();   // Tìm số lớn nhất trong một mảng
        BaiTap6();   // Tính tổng các số lẻ từ 1 đến 100
        BaiTap7();   // Đảo ngược chuỗi
        BaiTap8();   // In ra bảng cửu chương của một số
        BaiTap9();   // Đếm các số nguyên dương trong mảng
        BaiTap10();  // In tam giác số
        BaiTap11();  // Tìm phần tử nhỏ nhất trong mảng
        BaiTap12();  // In dãy Fibonacci đến n
        BaiTap13();  // Tính giai thừa của một số
        BaiTap14();  // In các số từ n đến 1
        BaiTap15();  // Tính tổng các phần tử trong mảng
        BaiTap16();  // Kiểm tra số nguyên tố
        BaiTap17();  // In các số chia hết cho 3 từ 1 đến 100
        BaiTap18();  // Tính tổng các số chẵn trong mảng
        BaiTap19();  // Tính trung bình cộng của mảng
        BaiTap20();  // Đếm số ký tự hoa trong chuỗi
    }

    // Bài Tập 1: In Các Số Từ 1 Đến 100
    void BaiTap1()
    {
        // Sử dụng vòng lặp For để in các số từ 1 đến 100
        var list = new List<int>();
        for (int i = 1; i <= 100; i++) list.Add(i);
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50
    void BaiTap2()
    {
        // Sử dụng vòng lặp For để tính tổng các số từ 1 đến 50
        int sum = 0;
        for (int i = 1; i <= 50; i++) sum += i;
    }

    // Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100
    void BaiTap3()
    {
        // Sử dụng vòng lặp For để in tất cả các số chẵn từ 1 đến 100
        var evens = new List<int>();
        for (int i = 2; i <= 100; i += 2) evens.Add(i);
    }

    // Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10
    void BaiTap4()
    {
        // Sử dụng vòng lặp For để tính tích các số từ 1 đến 10
        long product = 1;
        for (int i = 1; i <= 10; i++) product *= i;
    }

    // Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng
    void BaiTap5()
    {
        // Sử dụng vòng lặp For để tìm số lớn nhất trong một mảng số nguyên
        int[] a = { 3, 7, 2, 9, 5 };
        int max = a[0];
        for (int i = 1; i < a.Length; i++)
            if (a[i] > max) max = a[i];
    }

    // Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100
    void BaiTap6()
    {
        // Sử dụng vòng lặp For để tính tổng các số lẻ từ 1 đến 100
        int sumOdd = 0;
        for (int i = 1; i <= 100; i += 2) sumOdd += i;
    }

    // Bài Tập 7: Đảo Ngược Chuỗi
    void BaiTap7()
    {
        // Sử dụng vòng lặp For để đảo ngược một chuỗi
        string s = "Unity";
        char[] arr = new char[s.Length];
        for (int i = 0; i < s.Length; i++) arr[i] = s[s.Length - 1 - i];
        string reversed = new string(arr);
    }

    // Bài Tập 8: In Ra Bảng Cửu Chương
    void BaiTap8()
    {
        // Sử dụng vòng lặp For để in ra bảng cửu chương của một số bất kỳ (1–10)
        int n = 5;
        var table = new List<int>();
        for (int i = 1; i <= 10; i++) table.Add(n * i);
    }

    // Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng
    void BaiTap9()
    {
        // Sử dụng vòng lặp For để đếm số lượng các số nguyên dương trong một mảng
        int[] a = { -1, 2, 0, 5, -3 };
        int countPos = 0;
        for (int i = 0; i < a.Length; i++)
            if (a[i] > 0) countPos++;
    }

    // Bài Tập 10: In Tam Giác Số
    void BaiTap10()
    {
        // Sử dụng vòng lặp For để in ra một tam giác số
        // 1
        // 12
        // 123
        // 1234
        // 12345
        var triangle = new List<string>();
        for (int i = 1; i <= 5; i++)
        {
            string line = "";
            for (int j = 1; j <= i; j++) line += j;
            triangle.Add(line);
        }
    }

    // Bài Tập 11: Tìm Phần Tử Nhỏ Nhất Trong Mảng
    void BaiTap11()
    {
        // Sử dụng vòng lặp For để tìm phần tử nhỏ nhất trong một mảng số nguyên
        int[] a = { 3, 7, 2, 9, 5 };
        int min = a[0];
        for (int i = 1; i < a.Length; i++)
            if (a[i] < min) min = a[i];
    }

    // Bài Tập 12: In Dãy Fibonacci
    void BaiTap12()
    {
        // Sử dụng vòng lặp For để in ra dãy Fibonacci từ 1 đến n
        int n = 7;
        var fib = new List<int> { 1, 1 };
        for (int i = 2; i < n; i++)
            fib.Add(fib[i - 1] + fib[i - 2]);
    }

    // Bài Tập 13: Tính Giai Thừa Của Một Số
    void BaiTap13()
    {
        // Sử dụng vòng lặp For để tính giai thừa của một số nguyên dương n
        int n = 5;
        long fact = 1;
        for (int i = 1; i <= n; i++) fact *= i;
    }

    // Bài Tập 14: In Ra Các Số Nguyên Từ n Đến 1
    void BaiTap14()
    {
        // Sử dụng vòng lặp For để in ra các số nguyên từ n đến 1
        int n = 5;
        var rev = new List<int>();
        for (int i = n; i >= 1; i--) rev.Add(i);
    }

    // Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap15()
    {
        // Sử dụng vòng lặp For để tính tổng các phần tử trong một mảng số nguyên
        int[] a = { 1, 2, 3, 4, 5 };
        int sum = 0;
        for (int i = 0; i < a.Length; i++) sum += a[i];
    }

    // Bài Tập 16: Kiểm Tra Số Nguyên Tố
    void BaiTap16()
    {
        // Sử dụng vòng lặp For để kiểm tra xem một số nguyên có phải là số nguyên tố hay không
        int n = 29;
        bool isPrime = n > 1;
        for (int i = 2; i * i <= n && isPrime; i++)
            if (n % i == 0) isPrime = false;
    }

    // Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3
    void BaiTap17()
    {
        // Sử dụng vòng lặp For để in ra các số từ 1 đến 100 chia hết cho 3
        var div3 = new List<int>();
        for (int i = 1; i <= 100; i++)
            if (i % 3 == 0) div3.Add(i);
    }

    // Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng
    void BaiTap18()
    {
        // Sử dụng vòng lặp For để tính tổng các phần tử chẵn trong một mảng số nguyên
        int[] a = { 1, 2, 3, 4, 5, 6 };
        int sumEven = 0;
        for (int i = 0; i < a.Length; i++)
            if (a[i] % 2 == 0) sumEven += a[i];
    }

    // Bài Tập 19: Tính Trung Bình Cộng Của Mảng
    void BaiTap19()
    {
        // Sử dụng vòng lặp For để tính trung bình cộng của các phần tử trong một mảng số nguyên
        int[] a = { 1, 2, 3, 4, 5 };
        int total = 0;
        for (int i = 0; i < a.Length; i++) total += a[i];
        float avg = (float)total / a.Length;
    }

    // Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi
    void BaiTap20()
    {
        // Sử dụng vòng lặp For để đếm số lượng ký tự hoa trong một chuỗi
        string s = "HelloWorldUNITY";
        int count = 0;
        for (int i = 0; i < s.Length; i++)
            if (char.IsUpper(s[i])) count++;
    }
}