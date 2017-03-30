/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package facadepattern;

/**
 *
 * @author TIENIT
 */
public class SimpleProductFacade {
    
    DifficultProduct df;
    
    public SimpleProductFacade() {
        this.df = new DifficultProduct();
    }
    
    public void setName(String n) {
        
        char chars[] = n.toCharArray();
        
        if (chars.length > 0) {
            df.setFirstCharacter(chars[0]);
        }
        
        if (chars.length > 1) {
            df.setSecondCharacter(chars[1]);
        }
        
        if (chars.length > 2) {
            df.setThirdCharacter(chars[2]);
        }
        
        if (chars.length > 3) {
            df.setFourthCharacter(chars[3]);
        }
        
        if (chars.length > 4) {
            df.setFifthCharacter(chars[4]);
        }
        
        if (chars.length > 5) {
            df.setSixthCharacter(chars[5]);
        }
        
        if (chars.length > 6) {
            df.setSeventhCharacter(chars[6]);
        }
        
    }
    
    public String getName() {
        return df.getName();
    }
    
}
