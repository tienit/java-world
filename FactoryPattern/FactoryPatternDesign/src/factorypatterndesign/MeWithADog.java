/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorypatterndesign;

/**
 *
 * @author tiennu
 */
public class MeWithADog extends Me{

    @Override
    public Pet getMyPet() {
        return new Dog();
    }
    
}
