/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package finalkeywordtesting;

/**
 *
 * @author TIENIT
 */
public class Bike9 {
    final int speedLimit = 90;//variable final
    
    void run() {
        speedLimit = 400;
        System.out.println("Final vaule = " + String.valueOf(speedLimit));
    }
}
