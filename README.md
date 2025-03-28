# Hướng Dẫn Fork và Clone `HinMinh/SaiYouni`

## Bước 1: Fork Repository

1. Truy cập vào repository GitHub tại [HinMinh/SaiGameHW](https://github.com/HinMinh/SaiGameHW).
2. Ở góc trên bên phải, nhấp vào nút **Fork**. Điều này sẽ tạo một bản sao của repository dưới tài khoản GitHub của bạn.

## Bước 2: Clone Repository Đã Fork

1. Sau khi fork, vào tài khoản GitHub của bạn và tìm repository đã được fork.
2. Sao chép URL của repository bạn vừa fork. Nó sẽ trông như thế này: https://github.com/ten-tai-khoan-cua-ban/SaiGameHW.git.
3. Mở terminal (hoặc Git Bash trên Windows), và chạy lệnh sau để clone repository về máy tính của bạn:
git clone https://github.com/ten-tai-khoan-cua-ban/SaiYouni.git
4. Di chuyển vào thư mục của repository:
cd SaiYouni
## Bước 3: Thêm Repository Gốc Là Remote Upstream
1. Để giữ cho bản fork của bạn luôn đồng bộ với repository gốc, hãy thêm repository gốc làm một remote có tên là upstream:\
`git remote add upstream https://github.com/HinMinh/SaiGameHW.git`
2. Cập nhật thông tin mới của git dùng:\
`git fetch upstream`\
3a. Nếu nhánh đó mới thì bạn sử dụng:\
`git checkout Ten_Nhanh`\
3b. Nếu nhánh đó cũ thì bạn sử dụng merge:\
`git merge upstream/Ten_Nhanh`

## Kĩ thuật sử dụng github cơ bản
`git branch`: Hiển thị các nhánh bên trong dự án của bạn.\
`git checkout Ten Nhanh`: Thay đổi nhánh của bạn.\
`git pull`: Lấy dữ liệu mới về.\
`git add`: Thay đổi cập nhật vào git.\
`git commit -m "..."`: Chấp nhận thay đổi kèm theo lời nhắn những thay đổi đó là gì.\
`git push`: Đẩy lên github.

# Lưu ý khi đổi branch thì phải commit hết tại branch đó rồi mới đổi branch

# Task: Thiết Kế Kế Hoạch Làm Game Trong 1 Tháng (Được làm bằng chatgpt ¯\_(ツ)_/¯ )
Mục tiêu:
Phát triển một game đơn giản với gameplay Basic , đồ họa và âm thanh tối giản, hoàn thiện từ ý tưởng đến khi phát hành trong vòng 1 tháng ,(chủ yếu để biết cách làm game)

1. Tuần 1: Ý Tưởng & Thiết Kế Game

Brainstorm & Lên Ý Tưởng:
Tổ chức cuộc họp nhóm (hoặc tự brainstorming) để đưa ra ý tưởng game.
Xác định thể loại game (platformer, puzzle, arcade, v.v.) và gameplay cơ bản.
Tạo Game Design Document (GDD):
Soạn thảo tài liệu mô tả ý tưởng, cơ chế chơi, cốt truyện, nhân vật, đồ họa và âm thanh.
Phác Thảo Concept Art:
Vẽ sơ đồ giao diện, bản vẽ nhân vật và môi trường.
Cài Đặt Công Cụ & Tạo Repository:
Thiết lập dự án Unity.
Tạo repository Git (fork và clone theo hướng dẫn trong task Git).

2. Tuần 2: Phát Triển Gameplay & Prototype

Xây Dựng Prototype:
Lập trình các chức năng cơ bản: di chuyển nhân vật, va chạm, tấn công, và các hành động chính.
Thiết Kế Gameplay Core:
Phát triển hệ thống điểm, xử lý input và cơ chế game loop.
Tích Hợp Các Thành Phần Cơ Bản:
Thêm các đối tượng game như player, enemy (có thể dùng code mẫu của Task 3 và Task 4).
Kiểm Tra Ban Đầu:
Chạy thử prototype, ghi nhận các lỗi và cải tiến cần thiết.

3. Tuần 3: Tích Hợp Đồ Họa, Âm Thanh & Hiệu Ứng

Đồ Họa:
Tạo hoặc thu thập asset đồ họa đơn giản (sprite, background).
Tích hợp vào Unity và điều chỉnh giao diện game.
Âm Thanh:
Lựa chọn hoặc tạo nhạc nền, hiệu ứng âm thanh cho game.
Tích hợp âm thanh vào các sự kiện trong game (ví dụ: nhảy, va chạm, tấn công).
Hiệu Ứng & Tinh Chỉnh Gameplay:
Thêm hiệu ứng chuyển cảnh, particle system cho các hành động đặc biệt.
Tối ưu hóa gameplay, đảm bảo trải nghiệm mượt mà.

4. Tuần 4: Kiểm Thử, Tối Ưu & Phát Hành

Kiểm Thử Toàn Diện:
Thực hiện test toàn bộ game, kiểm tra các lỗi (bug) và các hành vi không mong muốn.
Thu thập phản hồi từ nhóm hoặc người chơi thử.
Tối Ưu Hóa & Fix Bug:
Sửa các lỗi phát hiện và tối ưu code, hiệu suất game.
Điều chỉnh giao diện, âm thanh và gameplay dựa trên phản hồi.
Chuẩn Bị Phát Hành:
Đóng gói game, tạo build phù hợp (PC, web, mobile tùy yêu cầu).
Soạn thảo tài liệu hướng dẫn sử dụng hoặc phát hành.
Cập nhật repository Git với phiên bản cuối cùng.