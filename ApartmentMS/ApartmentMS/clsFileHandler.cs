using System;
using System.Collections;
using System.Linq;
using System.Text;

public class clsFileHandler
{
    // List of the class data members.

    private string mFirstName, mLastName, mPlant, mDept, mGender, mEmployeeID;
    private DateTime mDateHired;
    private decimal mPayRate;
    private bool mSalaryInd;

    // ----------- Class constructors ----------------

    public clsFileHandler()
    {
    }

    public clsFileHandler(string p, string p2, string p3, string p4, string p5, DateTime p6, bool p7, string p8, decimal p9)
    {
        mPlant = p;
        mDept = p2;
        mEmployeeID = p3;
        mLastName = p4;
        mFirstName = p5;
        mDateHired = p6;
        mSalaryInd = p7;
        mGender = p8;
        mPayRate = p9;

    }

    // ----------- Accessor methods for data members ----------------

    // Purpose: Reads or writes the mName data member.

    public decimal PayRate
    {
        get
        {
            return mPayRate;
        }
        set
        {
            mPayRate = value;
        }
    }
    public string FirstName
    {
        get
        {
            return mFirstName;
        }
        set
        {
            mFirstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return mLastName;
        }
        set
        {
            mLastName = value;
        }
    }
    public string Plant
    {
        get
        {
            return mPlant;
        }
        set
        {
            mPlant = value;
        }
    }
    public string Dept
    {
        get
        {
            return mDept;
        }
        set
        {
            mDept = value;
        }
    }
    public DateTime DateHired
    {
        get
        {
            return mDateHired;
        }
        set
        {
            mDateHired = value;
        }
    }
    public bool SalaryInd
    {
        get
        {
            return mSalaryInd;
        }
        set
        {
            mSalaryInd = value;
        }
    }
    public string Gender
    {
        get
        {
            return mGender;
        }
        set
        {
            mGender = value;
        }
    }


    // ----------- End Accessor methods for data members ------------

    // Purpose:  Returns a string containing the object's state.
    public string Serialize()
    {
        return mFirstName.PadRight(10) + "   "
        + mLastName.PadRight(15) + "   "
        + mPlant.PadRight(12) + "   "
        + mDept.PadRight(10) + "   "
        + mDateHired.ToShortDateString().PadRight(10) + "   "
        + mSalaryInd.ToString().PadRight(10) + "   "
        + mGender.ToString().PadLeft(10) + "   "
        + mPayRate.ToString().PadRight(10);
    }
}