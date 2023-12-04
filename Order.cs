/*
Name: Bilal Bates
Date: 12/3/23
Assignment: CIS317 Course Project
Description: This is the Order class which is the base class for this program. 
*/
public class Order
{
    
    public int OrderNum { get; set; }
    public string OrderDate { get; set; }
    public bool ShippingStatus { get; set; }
    
    public Order(int orderNum, string orderDate, bool shippingStatus)
    {
        OrderNum = orderNum;
        OrderDate = orderDate;
        ShippingStatus = shippingStatus;
    }

    public virtual string GetOrderInfo()
    {
        return string.Format("\nOrder Number: {0}\nOrder Date: {1}\nShipping Status: {2}",
            OrderNum, OrderDate, ShippingStatus ? "Shipped" : "Not Shipped");
    }

    public override string ToString()
    {
        return GetOrderInfo();
    }
}