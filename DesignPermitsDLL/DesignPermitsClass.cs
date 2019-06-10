/* Title:           Design Permits Class
 * Date:        `   1-14-19
 * Author:          Terry HOlmes
 * 
 * Description:     This Class is used for Design Permits */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace DesignPermitsDLL
{
    public class DesignPermitsClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        DesignPermitsDataSet aDesignPermitsDataSet;
        DesignPermitsDataSetTableAdapters.designpermitsTableAdapter aDesignPermitsTableAdapter;

        InsertDesignPermitEntryTableAdapters.QueriesTableAdapter aInsertDesignPermitTableAdapter;

        CloseDesignPermitEntryTableAdapters.QueriesTableAdapter aCloseDesignPermitTableAdapter;

        UpdateDesignPermitStatusUpdateEntryTableAdapters.QueriesTableAdapter aUpdateDesignPermitStatusTableAdapter;

        FindOpenPermitsDataSet aFindOpenPermitsDataSet;
        FindOpenPermitsDataSetTableAdapters.FindOpenPermitsByDateRangeTableAdapter aFindOpenPermitsTableAdapter;

        FindPermitsByDateRangeDataSet aFindPermitsByDateRangeDataSet;
        FindPermitsByDateRangeDataSetTableAdapters.FindPermitsByDateRangeTableAdapter aFindPermitsByDateRangeTableAdapter;

        FindPermitsByProjectIDDataSet aFindPermitsByProjectIDDataSet;
        FindPermitsByProjectIDDataSetTableAdapters.FindPermitsByProjectIDTableAdapter aFindPermitsByProjectIDTableAdapter;

        FindOpenPermitsByProjectIDDataSet aFindOpenPermitsByProjectIDDataSet;
        FindOpenPermitsByProjectIDDataSetTableAdapters.FindOpenPermitsByProjectIDTableAdapter aFindOpenPermitsByProjectIDTableAdapter;

        FindPermitsByEmployeeDataSet aFindPermitsByEmployeeDataSet;
        FindPermitsByEmployeeDataSetTableAdapters.FindPermitsByEmployeeTableAdapter aFindPermitsByEmployeeTableAdapter;

        FindPermitsByLocationDataSet aFindPermitsByLocationDataSet;
        FindPermitsByLocationDataSetTableAdapters.FindPermitsByLocationTableAdapter aFindPermitsByLocationTableAdapter;

        public FindPermitsByLocationDataSet FindPermitsByLocation(int intWarehouseID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindPermitsByLocationDataSet = new FindPermitsByLocationDataSet();
                aFindPermitsByLocationTableAdapter = new FindPermitsByLocationDataSetTableAdapters.FindPermitsByLocationTableAdapter();
                aFindPermitsByLocationTableAdapter.Fill(aFindPermitsByLocationDataSet.FindPermitsByLocation, intWarehouseID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Find Permits By Location " + Ex.Message);
            }

            return aFindPermitsByLocationDataSet;
        }
        public FindPermitsByEmployeeDataSet FindPermitsByEmployee(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindPermitsByEmployeeDataSet = new FindPermitsByEmployeeDataSet();
                aFindPermitsByEmployeeTableAdapter = new FindPermitsByEmployeeDataSetTableAdapters.FindPermitsByEmployeeTableAdapter();
                aFindPermitsByEmployeeTableAdapter.Fill(aFindPermitsByEmployeeDataSet.FindPermitsByEmployee, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Find Permits By Employee " + Ex.Message);
            }

            return aFindPermitsByEmployeeDataSet;
        }
        public FindOpenPermitsByProjectIDDataSet FindOpenPermitsByProjectID(int intProjectID)
        {
            try
            {
                aFindOpenPermitsByProjectIDDataSet = new FindOpenPermitsByProjectIDDataSet();
                aFindOpenPermitsByProjectIDTableAdapter = new FindOpenPermitsByProjectIDDataSetTableAdapters.FindOpenPermitsByProjectIDTableAdapter();
                aFindOpenPermitsByProjectIDTableAdapter.Fill(aFindOpenPermitsByProjectIDDataSet.FindOpenPermitsByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Find Open Permits by Project ID " + Ex.Message);
            }

            return aFindOpenPermitsByProjectIDDataSet;
        }
        public FindPermitsByProjectIDDataSet FindPermitsByProjectID(int intProjectID)
        {
            try
            {
                aFindPermitsByProjectIDDataSet = new FindPermitsByProjectIDDataSet();
                aFindPermitsByProjectIDTableAdapter = new FindPermitsByProjectIDDataSetTableAdapters.FindPermitsByProjectIDTableAdapter();
                aFindPermitsByProjectIDTableAdapter.Fill(aFindPermitsByProjectIDDataSet.FindPermitsByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Find Permits By Project IT " + Ex.Message);
            }

            return aFindPermitsByProjectIDDataSet;
        }
        public FindPermitsByDateRangeDataSet FindPermitsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindPermitsByDateRangeDataSet = new FindPermitsByDateRangeDataSet();
                aFindPermitsByDateRangeTableAdapter = new FindPermitsByDateRangeDataSetTableAdapters.FindPermitsByDateRangeTableAdapter();
                aFindPermitsByDateRangeTableAdapter.Fill(aFindPermitsByDateRangeDataSet.FindPermitsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Find Permits By Date Range " + Ex.Message);
            }

            return aFindPermitsByDateRangeDataSet;
        }
        public FindOpenPermitsDataSet FindOpenPermits()
        {
            try
            {
                aFindOpenPermitsDataSet = new FindOpenPermitsDataSet();
                aFindOpenPermitsTableAdapter = new FindOpenPermitsDataSetTableAdapters.FindOpenPermitsByDateRangeTableAdapter();
                aFindOpenPermitsTableAdapter.Fill(aFindOpenPermitsDataSet.FindOpenPermitsByDateRange);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Find Open Permits " + Ex.Message);
            }

            return aFindOpenPermitsDataSet;
        }
        public bool UpdateDesignPermitStatus(int intTransactionID, string strPermitStatus, string strPermitNotes)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignPermitStatusTableAdapter = new UpdateDesignPermitStatusUpdateEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignPermitStatusTableAdapter.UpdateDesignPermitStatus(intTransactionID, strPermitStatus, strPermitNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Status " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool CloseDesignPermit(int intTransactionID, DateTime datDateComplete, string strPermitNotes)
        {
            bool blnFatalError = false;

            try
            {
                aCloseDesignPermitTableAdapter = new CloseDesignPermitEntryTableAdapters.QueriesTableAdapter();
                aCloseDesignPermitTableAdapter.CloseDesignPermit(intTransactionID, datDateComplete, strPermitNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Close Design Permit " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertDesignPermit(int intProjectID, DateTime datDateReceived, int intQuantity, string strPermitStatus, int intEmployeeID, string strPermitNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDesignPermitTableAdapter = new InsertDesignPermitEntryTableAdapters.QueriesTableAdapter();
                aInsertDesignPermitTableAdapter.InsertDesignPermit(intProjectID, datDateReceived, intQuantity, strPermitStatus, intEmployeeID, strPermitNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Insert Design Permit " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DesignPermitsDataSet GetDesignPermitsInfo()
        {
            try
            {
                aDesignPermitsDataSet = new DesignPermitsDataSet();
                aDesignPermitsTableAdapter = new DesignPermitsDataSetTableAdapters.designpermitsTableAdapter();
                aDesignPermitsTableAdapter.Fill(aDesignPermitsDataSet.designpermits);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Get Design Permits Info " + Ex.Message);
            }

            return aDesignPermitsDataSet;
        }
        public void UPdateDesignPermitsDB(DesignPermitsDataSet aDesignPermitsDataSet)
        {
            try
            {
                aDesignPermitsTableAdapter = new DesignPermitsDataSetTableAdapters.designpermitsTableAdapter();
                aDesignPermitsTableAdapter.Update(aDesignPermitsDataSet.designpermits);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Update Design Permits DB " + Ex.Message);
            }
        }
    }
}
