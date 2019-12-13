#include "pch.h"
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <string>
#include <iostream>
#include <windows.h>

HANDLE hOut;
using namespace std;
struct sinhvien {
	char Masv[50];
	char Ten[100];
	double Toan;
	double Ly;
	double Hoa;
};
//
struct Node {
	sinhvien key; //truong key cua du lieu
	Node *Left, *Right; //con trai va con phai
};
typedef Node *Tree;  //cay
					 //
					 // so sanh 2 item theo key
int compare(sinhvien x, sinhvien y)
{
	return strcmp(x.Masv, y.Masv);
}
//
// nhap 1 item
sinhvien Nhapsv()
{
	sinhvien x;
	cout << "Nhap Ma Sinh Vien (Q De Quay Lai): ";
	gets_s(x.Masv);
	if (strcmp(x.Masv, "q") == 0 || strcmp(x.Masv, "Q") == 0)
	{
		return x;
	}
	cout << "Nhap Ten Sinh Vien: ";
	gets_s(x.Ten);
	cout << "Nhap Diem Toan: ";
	while (true)
	{
		cin >> x.Toan;
		if (cin.fail() || x.Toan > 10 || x.Toan < 0)
		{
			cin.clear();
			_flushall();
			cin.ignore();
			cout << "Nhap Lai Diem Toan: ";

		}
		else
			break;
	}
	cout << "Nhap Diem Ly: ";
	while (true)
	{
		cin >> x.Ly;
		if (cin.fail() || x.Ly > 10 || x.Ly < 0)
		{
			cin.clear();
			_flushall();
			cin.ignore();
			cout << "Nhap Lai Diem Ly: ";

		}
		else
			break;
	}
	cout << "Nhap Diem Hoa: ";
	while (true)
	{
		cin >> x.Hoa;
		if (cin.fail() || x.Hoa > 10 || x.Hoa < 0)
		{
			cin.clear();
			_flushall();
			cin.ignore();
			cout << "Nhap Lai Diem Hoa: ";

		}
		else
			break;
	}


	while (getchar() != '\n');/////////////////

	return x;
}
void XuatSinhVien(sinhvien x)
{
	cout << "=================================" << endl;
	cout << "Ma So Sinh Vien: " << x.Masv << "\n";
	cout << "Ten Sinh Vien: " << x.Ten << "\n";
	cout << "Diem Toan: " << x.Toan << "\n";
	cout << "Diem Ly: " << x.Ly << "\n";
	cout << "Diem Hoa: " << x.Hoa << "\n";
}
int insertNode(Tree &T, sinhvien x) // chen 1 Node vao cay
{
	if (T != NULL) {
		if (compare(T->key, x) == 0)
			return -1;  // Node nay da co
		if (compare(T->key, x) > 0)
			return insertNode(T->Left, x); // chen vao Node trai
		else if (compare(T->key, x) < 0)
			return insertNode(T->Right, x);   // chen vao Node phai
	}
	T = (Node *)malloc(sizeof(Node));
	if (T == NULL)
		return 0;    // khong du bo nho
	T->key = x;
	T->Left = T->Right = NULL;
	return 1;   // ok
}
void CreateTree(Tree &T)        // nhap cay
{
	sinhvien x;
	while (1) {
		cout << "--Nhap Thong Tin Sinh Vien Can Them--" << endl << endl;
		x = Nhapsv();
		if (strcmp(x.Masv, "q") == 0 || strcmp(x.Masv, "Q") == 0)
			break;  // x = 0 thi thoat
		int check = insertNode(T, x);
		if (check == -1)
			cout << "---Ma Sinh Vien Da Co---\n" << endl;
		else if (check == 0)
			cout << "---Bo Nho Day---\n" << endl;
		else cout << "---Them Thanh Cong---\n\n";

	}
}
void LNR(Tree T)
{

	if (T != NULL)
	{
		LNR(T->Left);
		XuatSinhVien(T->key);
		LNR(T->Right);
	}
}
Tree searchSV(Tree T, char Masv[])     // tim nut co diem < 4
{
	Node *P = T;
	if (T != NULL)
	{
		if (strcmp(T->key.Masv, Masv) == 0)
		{
			return P;

		}
		else if (strcmp(T->key.Masv, Masv) > 0)
		{
			return searchSV(T->Left, Masv);
		}
		else
			return searchSV(T->Right, Masv);
	}
	else
		return NULL;
}
Tree Suasv(Tree P)
{

	cout << "Sua Ten Sinh Vien(Q De Quay Lai): ";
	gets_s(P->key.Ten);
	if (strcmp(P->key.Ten, "q") == 0 || strcmp(P->key.Ten, "Q") == 0)
	{
		return P;
	}
	cout << "Sua Diem Toan: ";
	while (true)
	{
		cin >> P->key.Toan;
		if (cin.fail() || P->key.Toan > 10 || P->key.Toan < 0)
		{
			cin.clear();
			_flushall();
			cin.ignore();
			cout << "Nhap Lai Diem Toan: ";

		}
		else
			break;
	}
	cout << "Sua Diem Ly: ";
	while (true)
	{
		cin >> P->key.Ly;
		if (cin.fail() || P->key.Ly > 10 || P->key.Ly < 0)
		{
			cin.clear();
			_flushall();
			cin.ignore();
			cout << "Nhap Lai Diem Ly: ";

		}
		else
			break;
	}
	cout << "Sua Diem Hoa: ";
	while (true)
	{
		cin >> P->key.Hoa;
		if (cin.fail() || P->key.Hoa > 10 || P->key.Hoa < 0)
		{
			cin.clear();
			_flushall();
			cin.ignore();
			cout << "Nhap Lai Diem Hoa: ";

		}
		else
			break;
	}

	while (getchar() != '\n');/////////////////

	return P;
}
//Xóa Sinh Viên
int delSV(Tree &T, char Masv[])     // xoa nut co key Masv
{
	if (T == NULL)
		return 0;
	else if (strcmp(T->key.Masv, Masv) > 0)
		return delSV(T->Left, Masv);
	else if (strcmp(T->key.Masv, Masv) < 0)
		return delSV(T->Right, Masv);
	else // T->key == x
	{
		Node *P = T;
		if (T->Left == NULL)
			T = T->Right;    // Node chi co cay con phai
		else if (T->Right == NULL)
			T = T->Left;   // Node chi co cay con trai
		else // Node co ca 2 con
		{
			Node *S = T, *Q = S->Left;
			// S la cha cua Q, Q la Node phai nhat cua cay con trai cua P
			while (Q->Right != NULL) {
				S = Q;
				Q = Q->Right;
			}
			P->key = Q->key;
			S->Right = Q->Left;
			delete Q;
		}
	}
	return 1;
}
void  ghifile(const char *filename, Tree &T)
{
	if (T != NULL)
	{

		FILE *f = fopen(filename, "ab");
		fprintf(f, "%s\n", T->key.Masv);
		//fwrite(T->key.Masv, 1, sizeof(T->key.Masv), f);
		fprintf(f, "%s\n", T->key.Ten);
		//fwrite(T->key.Masv, 1, sizeof(T->key.Masv), f);
		fprintf(f, "%f\n", T->key.Toan);
		fprintf(f, "%f\n", T->key.Ly);
		fprintf(f, "%f\n", T->key.Hoa);
		ghifile(filename, T->Left);
		ghifile(filename, T->Right);
		fclose(f);
	}
}
void docfile(const char *filename, Tree &T)
{
	sinhvien x;
	FILE *f = fopen(filename, "rb");
	if (f != NULL)
	{

		while (!feof(f))
		{
			fscanf(f, "%s\n", &x.Masv);
			fscanf(f, "%s\n", &x.Ten);
			char to[100];
			fgets(to, 100, f);
			x.Toan = atof(to);
			char l[100];
			fgets(l, 100, f);
			x.Ly = atof(l);
			char h[100];
			fgets(h, 100, f);
			x.Hoa = atof(h);
			insertNode(T, x);
		}
		fclose(f);
	}
	else
	{
		cout << "!!--Thong Bao: Danh Sach Sinh Vien Dang Rong, Xin Vui Long Nhap Sinh Vien--!!" << "\n\n";
		CreateTree(T); //Nhap cay
	}

}
int main()
{
	Tree T;
	T = NULL; //Tao cay rong
	cout << "------------ Chuong Trinh Quan Ly Sinh Vien Bang Cay Nhi Phan ------------" << "\n\n\n";
	const char *f = "Debug\QLSV.TXT";
	docfile(f, T);
	// Tao Menu
	int flag;
Menu: {
	system("cls");
	HANDLE hOut;
	cout << "----------Menu Chinh----------" << endl;
	hOut = GetStdHandle(STD_OUTPUT_HANDLE);

	SetConsoleTextAttribute(hOut,
		FOREGROUND_RED);
	cout << "1. Xem Danh Sach Sinh Vien" << endl;
	SetConsoleTextAttribute(hOut,
		FOREGROUND_RED |
		FOREGROUND_GREEN);
	cout << "2. Them Sinh Vien" << endl;
	SetConsoleTextAttribute(hOut,
		FOREGROUND_RED);
	cout << "3. Tim Sinh Vien Theo Ma Sinh Vien" << endl;
	SetConsoleTextAttribute(hOut,
		FOREGROUND_RED |
		FOREGROUND_GREEN);
	cout << "4. Xoa Sinh Vien Theo Ma Sinh Vien" << endl;
	SetConsoleTextAttribute(hOut,
		FOREGROUND_RED);
	cout << "5. Luu Du Lieu" << endl;
	SetConsoleTextAttribute(hOut,
		FOREGROUND_RED |
		FOREGROUND_GREEN);
	cout << "6. Thoat Chuong Trinh" << endl;
	SetConsoleTextAttribute(hOut,
		FOREGROUND_GREEN);
	cout << "----------------------------------------------------" << endl;
	SetConsoleTextAttribute(hOut,
		FOREGROUND_BLUE |
		FOREGROUND_RED);
	cout << "Nhap So De Thao Tac: ";
	SetConsoleTextAttribute(hOut,
		FOREGROUND_RED |
		FOREGROUND_GREEN |
		FOREGROUND_BLUE);
	cin >> flag;
	}
	  if (flag == 1)
	  {
		  system("cls");
		  char f;
		  LNR(T);
		  cout << "----------------------------------------------------" << endl;
		  cout << "1. Quay lai Menu Chinh <Y/N>: ";
		  cin >> f;
		  if (f == 'Y' || f == 'y')
			  goto Menu;
	  }
	  // them sinh vien
	  if (flag == 2)
	  {
		  system("cls");
		  cin.ignore();
		  CreateTree(T);
		  goto Menu;
	  }
	  if (flag == 3)
	  {
		  system("cls");
		  char Masv[50];
		  cin.ignore();
		  cout << "Nhap Ma Sinh Vien Can Tim: ";
		  gets_s(Masv);
		  Tree P = searchSV(T, Masv);
		  if (P != NULL)
		  {
			  int flag;
		  Menu2: {
			  system("cls");
			  cout << "----------Tim Thay Sinh Vien " << Masv << "----------" << endl;
			  cout << "1. Hien Thi Thong Tin Sinh Vien " << Masv << endl;
			  cout << "2. Sua Thong Tin Sinh Vien " << Masv << endl;
			  cout << "3. Quay lai Menu Chinh" << endl;
			  cout << "----------------------------------------------------" << endl;
			  cout << "Nhap So De Thao Tac: ";
			  cin >> flag;
			  }
				 if (flag == 1)
				 {
					 system("cls");
					 char f;
					 cout << "=================================" << endl;
					 cout << "Ma So Sinh Vien: " << P->key.Masv << "\n";
					 cout << "Ten Sinh Vien: " << P->key.Ten << "\n";
					 cout << "Diem Toan: " << P->key.Toan << "\n";
					 cout << "Diem Ly: " << P->key.Ly << "\n";
					 cout << "Diem Hoa: " << P->key.Hoa << "\n";
					 double TB = 0;
					 TB = (P->key.Toan + P->key.Ly + P->key.Hoa) / 3;
					 cout << "Diem Trung Binh: " << TB << endl;
					 cout << "----------------------------------------------------" << endl;
					 cout << "1. Quay lai Menu Sinh Vien <y/n>" << Masv << " : ";
					 cin >> f;
					 if (f == 'Y' || f == 'y')
						 goto Menu;
					 goto Menu2;
				 }
				 if (flag == 2)
				 {
					 system("cls");
					 cout << "Nhap Thong Tin Can Sua" << endl;
					 cin.ignore();
					 Suasv(P);
					 goto Menu2;
				 }
				 if (flag == 3)
				 {
					 system("cls");
					 goto Menu;
				 }
		  }
		  else
		  {
			  cout << "Khong Ton Tai Ma Sinh Vien Nay" << endl;
			  system("Pause");
		  }
		  goto Menu;
	  }
	  if (flag == 4)
	  {
		  system("cls");
		  char Masv[50];
		  cin.ignore();
		  cout << "Nhap Ma Sinh Vien Can Xoa: ";
		  gets_s(Masv);
		  Tree P = searchSV(T, Masv);
		  if (P != NULL)
		  {
			  int flag;
			  system("cls");
			  cout << "----------Tim Thay Sinh Vien " << Masv << "----------" << endl;
			  cout << "Ma So Sinh Vien: " << P->key.Masv << "\n";
			  cout << "Ten Sinh Vien: " << P->key.Ten << "\n";
			  cout << "Diem Toan: " << P->key.Toan << "\n";
			  cout << "Diem Ly: " << P->key.Ly << "\n";
			  cout << "Diem Hoa: " << P->key.Hoa << "\n";
			  double TB = 0;
			  TB = (P->key.Toan + P->key.Ly + P->key.Hoa) / 3;
			  cout << "Diem Trung Binh: " << TB << endl;
			  cout << "----------------------------------------------------" << endl;
			  cout << "1. Xoa Sinh Vien " << Masv << endl;
			  cout << "2. Huy Bo! va Quay lai Menu Chinh" << endl;
			  cout << "----------------------------------------------------" << endl;
			  cout << "Nhap So De Thao Tac: ";
			  cin >> flag;
			  if (flag == 1)
			  {
				  system("cls");
				  cin.ignore();
				  int del = 1;
				  while (del)
				  {
					  if (P != NULL)
					  {
						  cout << "---Xoa Thanh Cong---" << endl;
						  del = delSV(T, P->key.Masv);
					  }
					  else
					  {
						  cout << "Khong Co Du Lieu" << endl;
						  del = 0;
					  }
					  system("Pause");
					  goto Menu;
				  }
			  }
			  if (flag == 2)
			  {
				  system("cls");
				  goto Menu;
			  }
		  }
		  else
		  {
			  cout << "Khong Ton Tai Ma Sinh Vien Nay" << endl;
		  }
		  goto Menu;
	  }
	  if (flag == 5)
	  {
		  system("del Debug\QLSV.TXT");
		  system("cls");
		  cin.ignore();
		  ghifile(f, T);
		  cout << "Da Luu Du Lieu" << endl;
		  system("Pause");
		  goto Menu;
	  }
	  if (flag == 6)
	  {
		  return -1;
	  }

	  system("Pause");
	  return 0;
}