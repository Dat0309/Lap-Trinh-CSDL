#include<iostream>
using namespace std;


void NhapMang(int a[][100] , int n,int m) {
	for (int i = 0; i < n; i++) {
		for (int j = 0;j < m;j++) {
			cout << "\nNhap a[" << i << "][" << j << "]:";
			cin >> a[i][j];
		}
	}
}
void XuatMang(int a[][100], int n, int m) {
	for (int i = 0; i < n; i++) {
		for (int j = 0;j < m;j++) {
			cout << a[i][j]<<"    ";
		}
		cout << endl;
	}
}
int TimGiaTriLonNhat(int a[][100], int n, int m) {
	int MAX;
	for (int i = 0; i < n; i++) {
		MAX = a[0][0];
		for (int j = 0;j < m;j++) {
			if (a[i][j] > MAX) {
				MAX = a[i][j];
			}
		}
	}
	return MAX;
}
int TinhS(int a[][100], int n, int m) {
	int MIN,S=0;
	for (int i = 0; i < n; i++) {
		MIN = TimGiaTriLonNhat(a, n, m);

		for (int j = 0;j < m;j++) {
			if (a[i][j] < MIN && a[i][j]>0)
				MIN = a[i][j];
			MIN = 0;
			if (MIN == 0) {
				cout << "\nKhong co gia tri duong be nhat!";
			}
			else {

				cout << "\nGia tri nho nhat cua dong  " << i << "  la" << MIN;
				S += MIN;
			}
		}
	}
	return S;
}
int TimGiaTriNhoNhat(int a[][100], int n, int m) {
	int MIN;
	for (int j = 0; j < m; j++) {
		MIN = a[0][0];
		for (int i = 0;i < n;i++) {
			if (a[i][j] < MIN) {
				MIN = a[i][j];
			}

		}
	}
	return MIN;
}
int TinhT(int a[][100], int n, int m) {
	int MAX, S = 0;
	for (int j = 0; j < m; j++) {
		MAX = TimGiaTriNhoNhat(a, n, m);

		for (int i = 0;i < n;i++) {
			if (a[i][j] > MAX && a[i][j]<0)
				MAX =a[i][j];
			MAX = 0;	
		}
		if (MAX == 0) {
			cout << "\nKhong co gia tri am lon nhat!";
		}
		else {
			cout << "\nGia tri lon nhat cua cot  " << j << "  la" << MAX;
			S += MAX;
		}

	}
	return S;
}

void main() {
	int a[100][100];
	int n, m;
	cout << "\nNhap so dong cua mang: ";
	cin >> n;
	cout << "\nNhap so cot cua mang: ";
	cin >> m;
	cout << "\n\n\t\tNHAP MANG\n";
	NhapMang(a,n,m);
	cout << "\n\n\t\tXUAT MANG\n";
	XuatMang(a, n, m);
	cout << "\nGia tri cua S la:  " << TinhS(a, n, m);
	cout << "\nGia tri cua T la:   " << TinhT(a, n, m);

	system("pause");
}