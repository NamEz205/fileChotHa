insert into NhanVien values
('Cd11', N'Yến', N'Nữ', N'Nhân viên', '2025-08-12', N'Hà Nội', '011199111', 'OK'),
('Cd14', N'Nhi', N'Nữ', N'Nhân viên', '2025-10-15', N'Hà Nội', '011178787', 'OK'),
('Cd99', N'Huy', N'Nam', N'Quản Lý', '2025-11-29', N'Hà Nội', '0116741999', 'OK');

INSERT INTO LuongNhanVien (MaCLV, MaNV, SoCaLam, TongTien, NgayNhanLuong, GhiChu)
SELECT 
    '1', 
    NV.MaNV, 
    DATEDIFF(DAY, NV.NgayVaoLam, '2025-12-30') AS SoCaLam,
    DATEDIFF(DAY, NV.NgayVaoLam, '2025-12-30') * CLV.SoTien AS TongTien,
    '2025-09-30',
    N'Tổng Lương tháng'
FROM NhanVien NV
JOIN CaLamViec CLV ON CLV.MaCLV = '1'
WHERE NV.MaNV = 'cd99';


insert into CaLamViec values
(N'1', N'Đêm', N'250000', N''),
(N'2', N'Ngày', N'220000', N'');
