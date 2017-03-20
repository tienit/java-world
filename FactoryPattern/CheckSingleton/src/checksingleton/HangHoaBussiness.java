/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package checksingleton;

/**
 *
 * @author tiennu
 */
public final class HangHoaBussiness {
    
    private static HangHoaBussiness instance=new HangHoaBussiness();
    public static HangHoaBussiness getInstance()
    {
        return instance;
    }
}
