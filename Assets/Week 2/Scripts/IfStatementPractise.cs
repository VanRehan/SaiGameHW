using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1();   // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2();   // Kiểm tra số chẵn hay lẻ
        BaiTap3();   // Kiểm tra điều kiện thi đỗ
        BaiTap4();   // Tìm số lớn nhất trong hai số
        BaiTap5();   // Kiểm tra điều kiện mua hàng
        BaiTap6();   // Kiểm tra năm nhuận
        BaiTap7();   // Tính giá vé xem phim
        BaiTap8();   // Kiểm tra học sinh xuất sắc
        BaiTap9();   // So sánh ba số
        BaiTap10();  // Tính tiền lương
        BaiTap11();  // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12();  // Phân loại học sinh
        BaiTap13();  // Tính tiền điện
        BaiTap14();  // Kiểm tra điều kiện thăng chức
        BaiTap15();  // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16();  // Tính thuế thu nhập cá nhân
        BaiTap17();  // Tính điểm trung bình của môn học
        BaiTap18();  // Kiểm tra điều kiện nhập hàng
        BaiTap19();  // Tìm số lớn hơn 10
        BaiTap20();  // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        // Nhập một số từ bàn phím
        int n = -3;
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        string result;
        if (n > 0) result = "positive";
        else if (n < 0) result = "negative";
        else result = "zero";
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        // Nhập một số từ bàn phím
        int n = 4;
        // Kiểm tra xem số đó là số chẵn hay lẻ
        bool isEven;
        if (n % 2 == 0) isEven = true;
        else isEven = false;
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float avgScore = 6.5f;
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        bool passed = avgScore >= 5.0f;
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        int a = 7, b = 10;
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        int max = a > b ? a : b;
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        int money = 1000, price = 800;
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        bool canBuy = money >= price;
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        int year = 2024;
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        // Nhập tuổi của người mua vé từ bàn phím
        int age = 16;
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        int ticketPrice = age < 18 ? 50000 : 100000;
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float avg = 9.2f;
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        bool isExcellent = avg >= 9.0f;
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        // Nhập ba số nguyên từ bàn phím
        int x = 3, y = 7, z = 5;
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        int max = x;
        if (y > max) max = y;
        if (z > max) max = z;
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        int hours = 45, rate = 100;
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        float salary;
        if (hours > 40) salary = 40 * rate + (hours - 40) * rate * 2;
        else salary = hours * rate;
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        int age = 20;
        bool hasCard = true;
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        bool canEnter = age > 18 && hasCard;
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        float avg = 8.3f;
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        string grade;
        if (avg >= 9.0f) grade = "Xuất sắc";
        else if (avg >= 8.0f) grade = "Giỏi";
        else if (avg >= 7.0f) grade = "Khá";
        else if (avg >= 5.0f) grade = "Trung bình";
        else grade = "Yếu";
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        // Nhập số điện tiêu thụ từ bàn phím
        int kWh = 120;
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        int bill;
        if (kWh <= 100) bill = kWh * 1500;
        else bill = 100 * 1500 + (kWh - 100) * 2000;
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        // Nhập số năm làm việc và đánh giá công việc
        int years = 6;
        bool goodReview = true;
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        bool canPromote = years > 5 && goodReview;
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        // Nhập giá trị đơn hàng từ bàn phím
        int orderValue = 600000;
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        bool freeShipping = orderValue >= 500000;
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        // Nhập thu nhập từ bàn phím
        int income = 15000000;
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        float tax;
        if (income <= 10000000) tax = income * 0.05f;
        else if (income <= 20000000) tax = income * 0.10f;
        else tax = income * 0.20f;
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        float t1 = 6f, t2 = 7f, t3 = 8f;
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        float avg = (t1 + t2 + t3) / 3f;
        bool passed = avg >= 5.0f;
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        int quantity = 80;
        bool hasSpace = true;
        bool canRestock = quantity < 100 && hasSpace;
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        // Nhập một số từ bàn phím
        int num = 15;
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        bool isGreater = num > 10;
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        bool basicCompleted = true;
        float finalScore = 7.5f;
        bool hasRecommendation = true;
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        bool canRegister = basicCompleted && finalScore >= 7.0f && hasRecommendation;
    }
}
