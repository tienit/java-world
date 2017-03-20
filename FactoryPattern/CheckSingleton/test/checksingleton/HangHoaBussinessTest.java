/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package checksingleton;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author tiennu
 */
public class HangHoaBussinessTest {
    
    public HangHoaBussinessTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of getABC method, of class HangHoaBussiness.
     */
    @Test
    public void testGetABC() {
        System.out.println("getABC");
        HangHoaBussiness instance = new HangHoaBussiness();
        String expResult = "";
        String result = instance.getABC();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setABC method, of class HangHoaBussiness.
     */
    @Test
    public void testSetABC() {
        System.out.println("setABC");
        String _ABC = "";
        HangHoaBussiness instance = new HangHoaBussiness();
        instance.setABC(_ABC);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getInstance method, of class HangHoaBussiness.
     */
    @Test
    public void testGetInstance() {
        System.out.println("getInstance");
        HangHoaBussiness expResult = null;
        HangHoaBussiness result = HangHoaBussiness.getInstance();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
