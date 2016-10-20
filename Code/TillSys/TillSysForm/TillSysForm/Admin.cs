using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TillSysForm
{
    class Admin
    {
       private String firstName;
       private int staffID;
       private char status;
  

    public  Admin()
    {
       firstName ="Unknown";
       staffID = 0;
       status = 'n';

    }

    public Admin(String firstName, int staffID, char status)
    {
        this.firstName = firstName;
        this.staffID = staffID;
        this.status = status;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public void setFirstName(String firstName)
    {
        this.firstName = firstName;
    }


    public int getStaffID()
    {
        return staffID;
    }

    public void setStaffID(int staffID)
    {
        this.staffID = staffID;
    }

    public char getStatus()
    {
        return status;
    }

    public void setStatus(char status)
    {
        this.status = status;
    }



}
}
