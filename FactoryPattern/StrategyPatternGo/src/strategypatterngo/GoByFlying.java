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
public class GoByFlying implements GoAlgorithm {

    @Override
    public void go() {
        System.out.println("Now, I'm flying.");
    }
    
}
