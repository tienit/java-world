/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package strategypatterngo;

/**
 *
 * @author TIENIT
 */
public abstract class Vehicle {
    
    private final GoAlgorithm goAlgorithm;
    
    public Vehicle(GoAlgorithm goAlgorithm) {
        this.goAlgorithm = goAlgorithm;
    }
    
    public void go() {
        goAlgorithm.go();
    }
}
