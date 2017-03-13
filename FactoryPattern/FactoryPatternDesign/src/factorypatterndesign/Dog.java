/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorypatterndesign;

/**
 *
 * @author tiennu
 * Khai báo lớp Dog
 * Thuộc loại Pet
 */
public class Dog extends Pet{

    @Override
    public Pet giveBirth() {
        return new Dog();
    }

    @Override
    public void talk() {
        System.out.println("Wolf wolf");
    }
    
}
