# LibraryManagerMVC_2212447 - Hệ thống Quản lý Thư viện

## Mô tả dự án
Đây là hệ thống quản lý thư viện được xây dựng bằng ASP.NET Core MVC, thực hiện theo mô hình quan hệ thực thể (ERD) với hai bảng chính: Categories (Danh mục sách) và Books (Sách).

**Sinh viên:** Nguyễn Ngọc Tuệ Quang  
**MSSV:** 2212447

## Mô hình Cơ sở dữ liệu (ERD)

### Bảng Categories (Danh mục sách)
- **CategoryId** (int, PK): Khóa chính, định danh duy nhất cho mỗi danh mục
- **CategoryName** (varchar): Tên của danh mục (ví dụ: Khoa học, Văn học, CNTT...)
- **Description** (varchar): Mô tả chi tiết về danh mục

### Bảng Books (Sách)
- **BookId** (int, PK): Khóa chính, định danh duy nhất cho mỗi cuốn sách
- **Title** (varchar): Tựa đề sách
- **Author** (varchar): Tác giả của sách
- **ISBN** (varchar): Mã số ISBN duy nhất cho sách
- **PublishedYear** (int): Năm xuất bản
- **CategoryId** (int, FK): Khóa ngoại, liên kết đến CategoryId trong bảng Categories

### Mối quan hệ
- **One-to-Many**: Một Category có thể chứa nhiều Books, nhưng một Book chỉ thuộc về một Category duy nhất.

## Tính năng chính

### 🗂️ Quản lý Danh mục
- ✅ Xem danh sách tất cả danh mục với số lượng sách
- ✅ Thêm danh mục mới
- ✅ Sửa thông tin danh mục
- ✅ Xem chi tiết danh mục và sách thuộc danh mục
- ✅ Xóa danh mục (chỉ khi không có sách)

### 📚 Quản lý Sách
- ✅ Xem danh sách tất cả sách với thông tin danh mục
- ✅ Thêm sách mới với dropdown chọn danh mục
- ✅ Sửa thông tin sách
- ✅ Xem chi tiết sách
- ✅ Xóa sách
- ✅ Kiểm tra trùng lặp ISBN

### 🔧 Tính năng kỹ thuật
- ✅ Validation dữ liệu đầu vào
- ✅ Quan hệ Foreign Key giữa Books và Categories
- ✅ Giao diện responsive với Bootstrap
- ✅ Hiển thị bằng tiếng Việt
- ✅ Entity Framework Core với SQLite
- ✅ Seed data mẫu

## Yêu cầu hệ thống

- .NET 8.0 SDK
- Visual Studio 2022 (khuyến nghị) hoặc Visual Studio Code
- SQLite (tự động cài đặt qua NuGet)

## Cài đặt và chạy ứng dụng

### 1. Clone repository
```bash
git clone https://github.com/Quangnee89/2212447_NguyenNgocTueQuang_CSS.git
cd 2212447_NguyenNgocTueQuang_CSS/LibraryManagerMVC_2212447
```

### 2. Restore packages
```bash
dotnet restore
```

### 3. Chạy migration (nếu cần)
```bash
dotnet ef database update
```

### 4. Chạy ứng dụng
```bash
dotnet run
```

Ứng dụng sẽ chạy tại `https://localhost:5001` hoặc `http://localhost:5000`

## Sử dụng trong Visual Studio

1. Mở file `LibraryManagerMVC_2212447.sln` trong Visual Studio
2. Nhấn F5 hoặc click "Start" để chạy ứng dụng
3. Trình duyệt sẽ tự động mở trang chủ của ứng dụng

## 5 Kịch bản kiểm tra chính

### Kịch bản 1: Quản lý Danh mục sách
1. Truy cập `/Categories`
2. Xem danh sách danh mục có sẵn
3. Thêm danh mục mới: Click "Thêm danh mục mới"
4. Sửa danh mục: Click "Sửa" trên danh mục muốn chỉnh sửa
5. Xóa danh mục: Click "Xóa" (chỉ xóa được khi không có sách)

### Kịch bản 2: Quản lý Sách
1. Truy cập `/Books`
2. Xem danh sách sách có sẵn
3. Thêm sách mới: Click "Thêm sách mới", chọn danh mục từ dropdown
4. Sửa sách: Click "Sửa" trên sách muốn chỉnh sửa
5. Xóa sách: Click "Xóa"

### Kịch bản 3: Kiểm tra mối quan hệ Foreign Key
1. Thử xóa danh mục có sách → Hệ thống sẽ báo lỗi
2. Xem chi tiết danh mục → Hiển thị danh sách sách thuộc danh mục
3. Xem chi tiết sách → Hiển thị thông tin danh mục

### Kịch bản 4: Kiểm tra Validation
1. Thêm sách với ISBN trùng lặp → Hệ thống báo lỗi
2. Thêm sách/danh mục với thông tin thiếu → Hiển thị lỗi validation
3. Nhập năm xuất bản không hợp lệ → Validation range

### Kịch bản 5: Kiểm tra giao diện và điều hướng
1. Kiểm tra menu navigation hoạt động
2. Kiểm tra responsive design trên mobile
3. Kiểm tra các nút "Quay lại", "Thêm", "Sửa", "Xóa"
4. Kiểm tra hiển thị thông báo lỗi/thành công

## Cấu trúc thư mục

```
LibraryManagerMVC_2212447/
├── Controllers/
│   ├── BooksController.cs
│   ├── CategoriesController.cs
│   └── HomeController.cs
├── Models/
│   ├── Book.cs
│   ├── Category.cs
│   └── LibraryDbContext.cs
├── Views/
│   ├── Books/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   ├── Categories/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── Migrations/
└── Program.cs
```

## Dữ liệu mẫu

Hệ thống được cấu hình với dữ liệu mẫu bao gồm:

**Danh mục:**
- Khoa học
- Văn học
- CNTT
- Kinh tế
- Lịch sử

**Sách mẫu:**
- Lập trình C# cơ bản (CNTT)
- Truyện Kiều (Văn học)
- Vật lý đại cương (Khoa học)
- Quản lý dự án (Kinh tế)
- Lịch sử Việt Nam (Lịch sử)

## Công nghệ sử dụng

- **Backend**: ASP.NET Core 8.0 MVC
- **Database**: SQLite với Entity Framework Core
- **Frontend**: Bootstrap 5, HTML5, CSS3
- **Validation**: Data Annotations, Client-side validation
- **Architecture**: MVC Pattern với Repository Pattern

## Liên hệ

**Sinh viên:** Nguyễn Ngọc Tuệ Quang  
**MSSV:** 2212447  
**Email:** [Email sinh viên]

---

© 2025 - Hệ thống quản lý thư viện - Nguyễn Ngọc Tuệ Quang - 2212447