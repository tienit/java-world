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
public class Stanford_LamViecVoiMangJava {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        //Ví dụ 1: Khai báo 1 mảng số nguyên gồm 3 phần tử
        
        //Khai báo biến
        int a[] = new int[3];
        
        //Gán giá trị cho các phần tử
        a[0] = 2;
        
        a[1] = 3;
        
        a[2] = 6;
        
        //Hiển thị kết quả
        System.out.println("Danh sách các phần tử của mảng là: ");
        
        for(int v : a)
        {
            System.out.println(v);
        }
        
        //Ví dụ 2: Khai báo 1 mảng số thực gồm n phần tử nhập vào từ bàn phím. 
        //Sau đó thực hiện nhập các giá trị từ bàn phím và in thông tin ra màn hình
        
        //Khai báo biến n
        
        int n = 0;
        
        //Khai báo 1 đối tượng hỗ trợ nhập thông tin từ bàn phím
        Scanner scanner = new Scanner(System.in);
        
        System.out.print("Nhập mảng gồm n phần tử n = ");
        
        n = scanner.nextInt();
        
        //Khai báo 1 mảng gồm n phần tử
        
        float a1[] = new float[n];
        
        //Nhập thông tin cho các phần tử từ bàn phím
        for(int i = 0; i<n; i++)
        {
            System.out.print("a1[" + i + "] = ");
            
            a1[i] = scanner.nextFloat();
                    
        }
        
        //In kết quả ra màn hình
        System.out.println("Các phần tử của mảng là: ");
        for(int i = 0; i<n; i++)
        {
            System.out.println(a1[i]);
                    
        }
    }
    
}
