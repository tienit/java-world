/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package stanford_lamviecvoimangjava;

import java.util.Scanner;

/**
 *
 * @author dangquang
 */
public class MangHaiChieuJava {

      /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        //Khai báo mảng 2 chiều kiểu số nguyên
        
        int arr[][] = new int[3][2];
        
        /*
        a00 a01
        a10 a11
        a20 a21
        */
        
        //Gán giá trị cho các phần tử
        
        //DÒng 1
        arr[0][0] = 2;
        
        arr[0][1] = 3;
        
        //Dòng 2
        arr[1][0] = 5;
        
        arr[1][1] = 6;
        
        //Dòng 3
        arr[2][0] = 8;
        
        arr[2][1] = 9;
        
        //In thông tin ra màn hình
        System.out.println("Danh sách các phần tử của mảng 2 chiều là: ");
        
        for(int i = 0; i<3; i++)
        {
            for(int j = 0; j<2; j++)
            {
                System.out.print(arr[i][j] + "\t");
            }
            
            //Hết cột mới xuống dòng
            System.out.println("");
        }
        
        System.out.println("Lấy theo kích thước của mảng: ");
        
        for(int i = 0; i<arr.length; i++)
        {
            for(int j = 0; j<arr[i].length; j++)
            {
                System.out.print(arr[i][j] + "\t");
            }
            
            //Hết cột mới xuống dòng
            System.out.println("");
        }
        
        //Ví dụ 2: Khai báo 1 mảng 2 chiều gồm m dòng và n cột nhập vào từ bàn phím
        //Nhập dữ liệu cho các phần tử từ bàn phím và in thông tin ra màn hình
        
        //Khai báo biến
        int m = 0, n = 0;
        
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Nhập mảng gồm m dòng, m = ");
        
        m = scanner.nextInt();
        
        System.out.print("Nhập mảng gồm n cột, n = ");
        
        n = scanner.nextInt();
        
        //Khai báo 1 mảng
        
        float a1[][] = new float[m][n];
        
        //Nhập các phần tử cho mảng
        
        System.out.println("Nhập các phần tử cho mảng: ");
        
        for(int i = 0; i<m; i++)
        {
            for(int j = 0; j<n; j++)
            {
                System.out.print("a1[" + i + "][" + j + "] = ");
                
                a1[i][j] = scanner.nextFloat();
            }
        }
        
        System.out.println("Danh sách các phần tử của mảng 2 chiều: ");
        
        for(int i = 0; i<m; i++)
        {
            for(int j = 0; j<n; j++)
            {
                System.out.print(a1[i][j] + "\t");             
            }
            
            System.out.println("");
        }
    }
}
