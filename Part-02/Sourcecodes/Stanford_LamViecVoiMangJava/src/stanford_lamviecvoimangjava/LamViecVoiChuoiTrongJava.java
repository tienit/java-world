/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package stanford_lamviecvoimangjava;

/**
 *
 * @author dangquang
 */
public class LamViecVoiChuoiTrongJava {
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        //Khai báo 1 biến chuỗi
        String strThongTin = "Stanford";
        
        String strThongTin1 = "StanfordPro";
        
        int ketQua = strThongTin.compareTo(strThongTin1);
        
        System.out.println("Gía trị: " + ketQua);
        
        //Nối chuỗi
        strThongTin = strThongTin.concat(" - Dạy lập trình");
        
        System.out.println(strThongTin);
        
        //Hàm thay thế
        
        System.out.println(strThongTin.replace("t", "T"));
        
        //Chuyển về chữ hoa
        System.out.println("Chữ hoa: " + strThongTin.toUpperCase());
        
        //Chuyển về chữ thường
        System.out.println("Chữ thường: " + strThongTin.toLowerCase());
                
        //Tìm từ t đầu tiên
        
        int idx = strThongTin.indexOf('t');
        
        System.out.println("Vị trí Kí tự t đầu tiên: " + idx);
        
        int ldx = strThongTin.lastIndexOf('t');
        
        System.out.println("Vị trí Kí tự t cuối cùng: " + ldx);

        if(strThongTin.contains("Stanford"))
        {
            System.out.println("Chuỗi chứa từ Stanford");
        }
        
        String strStanford = strThongTin.substring(0, 8);
                        
        System.out.println("Tên viết tắt: " + strStanford)  ;
        
        System.out.println("Độ lớn của chuỗi là: " + strStanford.length());
        
        //Gán thông tin mới
        
        strThongTin = "10,50,90,40,30,60";
        
        //Chuyển chuỗi về dạng mảng
        String arr[] = strThongTin.split(",");
        
        //Duyệt để in thông tin
        
        System.out.println("Danh sách các giá trị lấy được từ chuỗi: ");
        
        for(String giaTri : arr)
        {
            System.out.println(giaTri);
        }
        
        strThongTin = "Stanford - Đào tạo và phát triển công nghệ";
        
        if(strThongTin.startsWith("S"))
        {
            System.out.println("Chuỗi bắt đầu bằng từ S");
        }
        
        //Khai báo 1 đối tượng StringBuilder
        
        StringBuilder builder = new StringBuilder();
        
        //Thêm thông tin
        builder.append("Stanford - Đào tạo và phát triển công nghệ");
        
        builder.append("\nChuyên đào tạo các khoá học về lập trình với các ngôn ngữ c/c++, c#, java, lập trình di động");
        
        builder.append("\nĐiện thoại: 04.6275.2212 - 04.6662.3355");
        
        builder.append("\nWebsite: www.stanford.com.vn");
        
        //In thông tin
        System.out.println(builder.toString());
                
                
        
    }
}
