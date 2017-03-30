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
public abstract class RobotTemplate {
    
    public final void go() {
        start();
        getParts();
        assemble();
        test();
        stop();
    }
    
    public void start() {
        System.out.println("Starting ...");
    }
    
    public void getParts() {
        System.out.println("Getting parts ...");
    }
    
    public void assemble() {
        System.out.println("Assembling ...");
    }
    
    public void test() {
        System.out.println("Testing ...");
    }
    
    public void stop() {
        System.out.println("Stopping ...");
    }
    
}
