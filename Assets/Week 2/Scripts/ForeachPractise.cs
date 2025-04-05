using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1();  // In tất cả các phần tử trong mảng
        BaiTap2();  // Tính tổng các phần tử trong mảng
        BaiTap3();  // Tìm phần tử lớn nhất trong mảng
        BaiTap4();  // Đếm số lượng số chẵn trong mảng
        BaiTap5();  // In tất cả các chuỗi trong danh sách
        BaiTap6();  // Tìm chuỗi dài nhất trong danh sách
        BaiTap7();  // Tính tổng các số lẻ trong mảng
        BaiTap8();  // In các số chẵn trong mảng
        BaiTap9();  // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để in tất cả các phần tử
        var result = new List<int>();
        foreach (var n in numbers) result.Add(n);
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để tính tổng
        int sum = 0;
        foreach (var n in numbers) sum += n;
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 3, 7, 2, 9, 5 };
        // Sử dụng foreach để tìm max
        int max = numbers[0];
        foreach (var n in numbers) if (n > max) max = n;
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, -2 };
        // Sử dụng foreach để đếm số chẵn
        int count = 0;
        foreach (var n in numbers) if (n % 2 == 0) count++;
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        var list = new List<string> { "apple", "banana", "cherry", "date" };
        // Sử dụng foreach để in tất cả các chuỗi
        var result = new List<string>();
        foreach (var s in list) result.Add(s);
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        var list = new List<string> { "apple", "banana", "cherry", "date" };
        // Sử dụng foreach để tìm chuỗi dài nhất
        string longest = list[0];
        foreach (var s in list) if (s.Length > longest.Length) longest = s;
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        // Sử dụng foreach để tính tổng số lẻ
        int sumOdd = 0;
        foreach (var n in numbers) if (n % 2 != 0) sumOdd += n;
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        // Sử dụng foreach để in số chẵn
        var evens = new List<int>();
        foreach (var n in numbers) if (n % 2 == 0) evens.Add(n);
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và phần tử cần kiểm tra
        int[] numbers = { 1, 2, 3, 4, 5 };
        int target = 3;
        // Sử dụng foreach để kiểm tra tồn tại
        bool found = false;
        foreach (var n in numbers) if (n == target) { found = true; break; }
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -3, 1, -2, 4, 0, -5 };
        // Sử dụng foreach để đếm số âm
        int negCount = 0;
        foreach (var n in numbers) if (n < 0) negCount++;
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 11, 15, 3, 20 };
        // Sử dụng foreach để in số > 10
        var overTen = new List<int>();
        foreach (var n in numbers) if (n > 10) overTen.Add(n);
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        var list = new List<string> { "abc", "de", "fghi", "j" };
        // Sử dụng foreach để tìm chuỗi ngắn nhất
        string shortest = list[0];
        foreach (var s in list) if (s.Length < shortest.Length) shortest = s;
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4 };
        // Sử dụng foreach để nhân đôi
        var tmp = new List<int>();
        foreach (var n in numbers) tmp.Add(n * 2);
        numbers = tmp.ToArray();
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 5, 3, 9, 7 };
        // Sử dụng foreach để tìm số lớn thứ hai
        int max = numbers[0], second = int.MinValue;
        foreach (var n in numbers)
            if (n > max) { second = max; max = n; }
            else if (n > second && n < max) second = n;
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        var list = new List<string> { "Apple", "Banana", "Apricot", "Cherry" };
        // Sử dụng foreach để lọc chuỗi bắt đầu 'A'
        var result = new List<string>();
        foreach (var s in list) if (s.StartsWith("A")) result.Add(s);
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        var list = new List<string> { "Hello", "World", "Unity" };
        // Sử dụng foreach để kiểm tra "Hello"
        bool hasHello = false;
        foreach (var s in list) if (s == "Hello") { hasHello = true; break; }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -1, 2, -3, 4, -5 };
        // Sử dụng foreach để in phần tử âm
        var negatives = new List<int>();
        foreach (var n in numbers) if (n < 0) negatives.Add(n);
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và phần tử cần đếm
        int[] numbers = { 1, 2, 3, 2, 4, 2 };
        int target = 2;
        // Sử dụng foreach để đếm số lần xuất hiện
        int count = 0;
        foreach (var n in numbers) if (n == target) count++;
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 12, 8, 15, 3, 20 };
        // Sử dụng foreach để lọc > 10
        var filtered = new List<int>();
        foreach (var n in numbers) if (n > 10) filtered.Add(n);
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        var list = new List<string> { "Unity3D", "GameDev", "AI", "MachineLearning" };
        // Sử dụng foreach để in chuỗi dài > 5
        var result = new List<string>();
        foreach (var s in list) if (s.Length > 5) result.Add(s);
    }
}
