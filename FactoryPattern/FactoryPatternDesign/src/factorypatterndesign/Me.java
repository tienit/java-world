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
public abstract class Me {
    public abstract Pet getMyPet();
    
    public void introduceMyPet(){
        Pet myPet = getMyPet();
        System.out.println("The parent pet talk:");
        myPet.talk();
        System.out.println("It's giving birth !!!");
        Pet child = myPet.giveBirth();
        System.out.println("The new born pet talks:");
        child.talk();
    }
}
