/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package templatemethodpattern;

/**
 *
 * @author TIENIT
 */
public class CookieRobot extends RobotTemplate {
    
    private String name;
    
    public CookieRobot(String n) {
        this.name = n;
    }
    
    public String getName() {
        return this.name;
    }
    
    @Override
    public void getParts() {
        System.out.println("Getting flour and sugar ...");
    }
    
    @Override
    public void assemble() {
        System.out.println("Baking a cookie ...");
    }
    
    @Override
    public void test() {
        System.out.println("Crunching a cookie ...");
    }
    
}
