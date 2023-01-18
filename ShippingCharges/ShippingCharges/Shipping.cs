using System;
using System.Collections.Generic;

public class Shipping
{
    public int packageW = 0;
    public int mile = 0;
    public float shippingCharges()
    {
        float charge;
        if (packageW <= 2)
        {
            charge = 1.1f;
        }
        else if (packageW > 2 && packageW <= 6)
        {
            charge = 2.20f;
        }
        else if (packageW > 6 && packageW <= 10)
        {
            charge = 3.70f;
        }
        else
        {
            charge = 4.8f;
        }

        if (mile > 500)
        {
            if (packageW <= 2)
            {
                charge = 2.2f;
            }
            else if (packageW > 2 && packageW <= 6)
            {
                charge = 3.70f;
            }
            else if (packageW > 6 && packageW <= 10)
            {
                charge = 4.8f;
            }
            else
            {
                charge = 4.8f;
            }
        }
        return charge;
    }
}
