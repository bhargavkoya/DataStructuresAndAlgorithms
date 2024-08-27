//public class addPolynomial
//{
//    ListNode addPolynomialCal(ListNode p1, ListNode p2)
//    {
//        ListNode res = new ListNode(
//            0, 0); // dummy node ...head of resultant list
//        ListNode prev
//            = res; // pointer to last node of resultant list
//        // like Merge procedure :
//        while (p1 != null && p2 != null)
//        {
//            if (p1.pow < p2.pow)
//            {
//                prev.next = p2;
//                prev = p2;
//                p2 = p2.next;
//            }
//            else if (p1.pow > p2.pow)
//            {
//                prev.next = p1;
//                prev = p1;
//                p1 = p1.next;
//            }
//            else
//            {
//                p1.coeff = p1.coeff + p2.coeff;
//                prev.next = p1;
//                prev = p1;
//                p1 = p1.next;
//                p2 = p2.next;
//            }
//        }
//        if (p1 != null)
//        {
//            prev.next = p1;
//        }
//        if (p2 != null)
//        {
//            prev.next = p2;
//        }
//        return res.next;
//    }
//}