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
public class DifficultProduct {
    
    char nameChars[] = new char[7];
    
    public DifficultProduct() {
    }
    
    public void setFirstCharacter(char c) {
        nameChars[0] = c;
    }
    
    public void setSecondCharacter(char c) {
        nameChars[1] = c;
    }
    
    public void setThirdCharacter(char c) {
        nameChars[2] = c;
    }
    
    public void setFourthCharacter(char c) {
        nameChars[3] = c;
    }
    
    public void setFifthCharacter(char c) {
        nameChars[4] = c;
    }
    
    public void setSixthCharacter(char c) {
        nameChars[5] = c;
    }
    
    public void setSeventhCharacter(char c) {
        nameChars[6] = c;
    }
    
    public String getName() {
        return new String(nameChars);
    }
    
}
