/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package decoratorpatternhouse;

/**
 *
 * @author TIENIT
 */
public class BuildThirdFloor extends ComponentDecorator {
    
    House house;
    
    public BuildThirdFloor(House h) {
        this.house = h;
    }

    @Override
    public String description() {
        return house.description() + " and 3rd floor";
    }
    
    
}
