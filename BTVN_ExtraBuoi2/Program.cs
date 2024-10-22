// See https://aka.ms/new-console-template for more information

#region Bài 6: Tính số dư sau khi rút tiền từ tài khoản
Console.WriteLine("Nhập số tiền trong tài khoản của bạn(VND): ");
string taikhoan = Console.ReadLine();
double account = Convert.ToDouble(taikhoan);

Console.WriteLine("Nhập số tiền cần rút(VND)(không được vượt quá số tiền trong tài khoản): ");
string tienrut = Console.ReadLine();
double rut = Convert.ToDouble(tienrut);

double conlai = account - rut;
Console.WriteLine($"Số tiền còn lại trong tài khoản sau khi rút: {conlai}");
#endregion



#region Bài 7: Tính tốc độ trung bình
Console.WriteLine("Nhập quãng đường đã đi(km):");
string quangduong = Console.ReadLine();
double s = Convert.ToDouble(quangduong);

Console.WriteLine("Nhập thời gian đã đi(giờ): ");
string time = Console.ReadLine();
double t = Convert.ToDouble(time);

double v= s/t;
Console.WriteLine($"Vận tốc của bạn là: {v} km/h");
#endregion



#region Bài 8: Tính tỷ lệ phần trăm
Console.WriteLine("Nhập số a: ");
string a = Console.ReadLine();
double soA= Convert.ToDouble(a);

Console.WriteLine("Nhập số b(Số b phải lớn hơn số a): ");
string b = Console.ReadLine();
double soB= Convert.ToDouble(b);

double c = soA/soB*100;

Console.WriteLine($"Phần trăm của số a trong số b là: {c}");
#endregion



#region Bài 9: Chuyển đổi từ km/h => m/s
Console.WriteLine("Nhập vận tốc cần đổi(km/h):");
string km = Console.ReadLine();
double kms = Convert.ToDouble(km);

double ms= kms / 3.6;
Console.WriteLine($"Vận tốc của bạn sau khi đổi là: {ms} m/s");

#endregion




#region Bài 10:  
Console.WriteLine("Mời bạn nhập số phút đã tập: ");
string phut = Console.ReadLine();
int minutes = Convert.ToInt32(phut);

Console.WriteLine("Mời bạn chọn loại hình tập thể dục(nhập số): ");
Console.WriteLine("1. Chạy bộ");
Console.WriteLine("2. Đạp xe");
Console.WriteLine("3. Bơi lội");
string chon = Console.ReadLine();
int choN = Convert.ToInt32(chon);

int chaybo = 50;
int dapxe = 30;
int boiloi = 100;
int calo =0;
if (choN ==1) {
    calo = minutes*chaybo;

}
else if (choN ==  2)
    {
        calo = minutes*dapxe;
    }
else 
    {
        calo = minutes*boiloi;
    }

    Console.WriteLine($"Số calo bạn đã tiêu thụ là: {calo}");

#endregion
