/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package stanford_lamviecvoimangjava;

import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Set;

/**
 *
 * @author dangquang
 */
public class LamViecVoiDanhSachTrongJava {
    
     /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        
        //Khai báo 1 danh sách sử dụng arraylist
        
        ArrayList arr = new ArrayList();
        
        //Thêm các phần tử vào danh sách
        
        arr.add("Stanford - Dạy lập trình");
        
        arr.add(20);
        
        arr.add(new Date());
        
        arr.add("Website: www.stanford.com.vn");
        
        //Duyệt danh sách để in thông tin ra màn hình
        for(Object giaTri: arr)
        {
            System.out.println(giaTri.toString());
        }
        
        //Khai báo 1 mảng danh sách
        
        List<String> lstKhoaHoc = new ArrayList();
        
        //Thêm các thông tin vào danh sách khoá học
        
        lstKhoaHoc.add("Java Core");
        
        lstKhoaHoc.add("Android");
        
        lstKhoaHoc.add("C#");
        
        lstKhoaHoc.add("J2EE");
        
        lstKhoaHoc.add("Hibernate");
        
        lstKhoaHoc.add("Struts2");
        
        //Chèn vào vị trí
        lstKhoaHoc.set(1, "PHP");
        
        //Xoá thông tin
        lstKhoaHoc.remove("Hibernate");
        
        //In thông tin ra màn hình
        System.out.println("Các khoá học là: ");
        
        for(String khoaHoc : lstKhoaHoc)
        {
            System.out.println(khoaHoc);
        }
        
        //Mảng cặp, xác định bởi key và value
        Map<String, String> arrKeys = new HashMap<>();
        
        //Gán giá trị
        arrKeys.put("server", "192.168.1.200");
        
        arrKeys.put("website", "stanford.com.vn");
        
        arrKeys.put("username", "stanford");
        
        //Lấy thông tin
        System.out.println("Server: " + arrKeys.get("server"));
        
        System.out.println("website: " + arrKeys.get("website"));
        
        System.out.println("username: " + arrKeys.get("username"));
        
        //Duyệt tất cả danh sách thông tin
        System.out.println("Các thông tin trong mảng cặp: ");
        
        Set<String> setKeys = arrKeys.keySet();
        
        Iterator<String> iterator = setKeys.iterator();
        
        while(iterator.hasNext())
        {
            String key = iterator.next();
            
            String value = arrKeys.get(key);
            
            System.out.println("Key: " + key + ", value: " + value);
        }
                
        
        
    }
}
