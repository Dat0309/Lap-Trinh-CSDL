#include<iostream>
#include<string.h>
#define MAX 100
typedef char String[MAX];

using namespace std;

void Menu(String a, char kt) {
	int luachon;
	while (true) {
		system("cls");
		cout << "\n\n\t\t========MENU========\n";
		cout << "\n0. Thoat khoi chong trinh";
		cout << "\n1. Nhap chuoi";
		cout << "\n2. Xem chuoi";
		cout << "\n3. Tinh chieu dai chuoi";
		cout << "\n4. Noi chuoi";
		cout << "\n\n\t\t========END========\n";
		do {
			cout << "\n\nNhap lua chon tu [0 ; 4]: ";
			cin >> luachon;
			if (luachon < 0 && luachon>4) {
				cout << "\nlua chon khong ton tai hay nhap lai!";
			}
		} while (luachon < 0 && luachon>4);
		if (luachon == 1) {
			cout << "\n1. Nhap chuoi";
			NhapChuoi(a,'a');

			system("pause");
		}
		else if (luachon == 2) {
			cout << "\n2. Xem chuoi";
			XuatChuoi(a);
			system("pause");
		}
		else if (luachon == 3) {
			cout << "\n3. Tinh chieu dai chuoi";
			system("pause");
		}
		else if (luachon == 4) {
			cout << "\n4. Noi chuoi";
			system("pause");
		}
		else if (luachon == 0) {
			cout << "\n0. Thoat khoi chong trinh";
			break;
		}
	}
}
void NhapChuoi(String a, char kt)
{
	cout << "\nNhap chuoi: " << kt << " = ";
	fflush(stdin);
	gets_s(a,MAX);
}
void XuatChuoi(String a)
{
	cout << a;
}
void strcat_s_Noi_ChuoiSau_VaoSau_ChuoiTruoc(String a, String b)
{
	strcat_s(a, MAX, b);
}


int main() {

	Menu();

	system("pause");
	return 0;
}