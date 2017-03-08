/**
 * 
 */
package vn.com.stanford.cautruclaptrinhjava;

import java.util.Scanner;

/**
 * @author DANGQUANG
 *
 */
public class CauTrucLapTrinhIfElse {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		//Khai báo biến
		float chieuCaoHung = 0, chieuCaoMao = 0;
		
		//Khai báo 1 đối tượng để lấy được thông tin người dùng nhập vào từ bàn phím
		Scanner scanner = new Scanner(System.in);
		
		//Nhập chiều cao của Hùng
		System.out.print("Nhập chiều của Hùng là: ");
		
		chieuCaoHung = scanner.nextFloat();
		
		//Nhập chiều cao của Mão
		System.out.print("Nhập chiều của Mão là: ");
				
		chieuCaoMao = scanner.nextFloat();
		
		//So sánh chiều cao của hai bạn
		if (chieuCaoHung == chieuCaoMao) {
			System.out.println("Chiều cao của hai bạn bằng nhau");
		} else {
			if (chieuCaoHung > chieuCaoMao) {
				System.out.println("Chiều cao Hùng lớn hơn Mão");
			} else {
				System.out.println("Chiều cao Mão lớn hơn Hùng");
			}
		}
	}

}
