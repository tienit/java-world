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
public class StrategyPatternGo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
//        StreetCar streetCar = new StreetCar(new GoByDriving());
//        FormulaOne formulaOne = new FormulaOne(new GoByDriving());
//        Helicopter helicopter = new Helicopter(new GoByFlying());
//        Jet jet = new Jet(new GoByFlyingFast());
//        
//        streetCar.go();
//        formulaOne.go();
//        helicopter.go();
//        jet.go();

        Jet jet = new Jet(new GoByDriving());
        jet.go();
        jet = new Jet(new GoByFlying());
        jet.go();
        jet = new Jet(new GoByFlyingFast());
        jet.go();
        
    }
    
}
