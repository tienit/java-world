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
public class AutomotiveRobot extends RobotTemplate {
    
    private String name;
    
    public AutomotiveRobot(String n) {
        this.name = n;
    }
    
    public String getName() {
        return this.name;
    }
    
    @Override
    public void getParts() {
        System.out.println("Getting a carburetor ...");
    }
    
    @Override
    public void assemble() {
        System.out.println("Installing a carburetor ...");
    }
    
    @Override
    public void test() {
        System.out.println("Revving the engine ...");
    }
    
}
