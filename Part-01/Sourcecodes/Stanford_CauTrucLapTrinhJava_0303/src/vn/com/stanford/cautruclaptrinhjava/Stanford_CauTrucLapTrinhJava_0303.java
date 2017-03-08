/**
 * 
 */
package vn.com.stanford.cautruclaptrinhjava;

import java.util.Scanner;

/**
 * @author DANGQUANG
 *
 */
public class Stanford_CauTrucLapTrinhJava_0303 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		//Ví dụ 1: Thực hiện viết 1 chương trình tính tổng hai số nhập vào từ bàn phím.
		
		//Khai báo biến
		int soThuNhat = 0, soThuHai = 0, tongHaiSo = 0;
		
		//Khai báo 1 đối tượng để nhập thông tin bàn phím
		Scanner scanner = new Scanner(System.in);
		
		//Hiển thị thông báo người dùng cần nhập số thứ nhất là
		System.out.print("Nhập số thứ nhất là: ");
		
		//Gán thông tin từ bán phím cho biến 1
		soThuNhat = scanner.nextInt();
		
		System.out.print("Nhập số thứ hai là: ");
		
		//Gán thông tin từ bán phím cho biến 2
		soThuHai = scanner.nextInt();
		
		//Thực hiện phép toán
		tongHaiSo = soThuNhat + soThuHai;
		
		System.out.println("Tổng hai số là: " + tongHaiSo);
	}

}
