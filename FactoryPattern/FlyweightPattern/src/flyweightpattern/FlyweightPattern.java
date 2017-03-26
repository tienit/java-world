/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package flyweightpattern;

/**
 *
 * @author TIENIT
 */
public class FlyweightPattern {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        String names[] = {"tienit", "duiu", "tintin"};
        int ids[] = {1001, 1002, 1003};
        int scores[] = {45, 55, 65};
        
        double total= 0;
        for (int i = 0; i < scores.length; i++) {
            total += scores[i];
        }
        double averageScore = total / scores.length;
        
//        Student stu = new Student(averageScore);
//        
//        for (int i = 0; i < scores.length; i++) {
//            stu.setName(names[i]);
//            stu.setId(ids[i]);
//            stu.setScore(scores[i]);
//            
//            System.out.println("Name: " + stu.getName());
//            System.out.println("Standing: " + Math.round(stu.getStanding()));
//            System.out.println(" ");
//        }
            
        StudentThreaded stuThreaded = StudentThreaded.getInstance();
        
        for (int i = 0; i < scores.length; i++) {
            stuThreaded.setName(names[i]);
            stuThreaded.setId(ids[i]);
            stuThreaded.setScore(scores[i]);
            stuThreaded.setAverageScore(averageScore);
            
            System.out.println("Name: " + stuThreaded.getName());
            System.out.println("Standing: " + Math.round(stuThreaded.getStanding()));
            System.out.println(" ");
        }
        
    }
    
}
