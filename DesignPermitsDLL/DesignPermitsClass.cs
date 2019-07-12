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

        UpdateDesignProjectPermitCostEntryTableAdapters.QueriesTableAdapter aUpdateDesignProjectPermitCostTableAdapter;

        DesignPermitImportDataSet aDesignPermitImportDataSet;
        DesignPermitImportDataSetTableAdapters.designpermitimportTableAdapter aDesignPermitImportTableAdapter;

        InsertDesignPermitImportEntryTableAdapters.QueriesTableAdapter aInsertDesignPermitImportTableAdapter;

        FindDesignPermitImportByTransactionDateDataSet aFindDesignPermitImportbyTransactionDateDataSet;
        FindDesignPermitImportByTransactionDateDataSetTableAdapters.FindDesignPermitImportByTransactionDateTableAdapter aFindDesignPermitImportByTransactionDateTableAdapter;

        UpdateDesignPermitSubmittedEntryTableAdapters.QueriesTableAdapter aUpdateDesignPermitSubmittedTableAdapter;

        UpdateDesignPermitApprovalEntryTableAdapters.QueriesTableAdapter aUpdateDesignPermitApprovalTableAdapter;

        UpdateDesignPermitExpirationDateEntryTableAdapters.QueriesTableAdapter aUpdateDesignPermitExpirationDateTableAdapter;

        UpdateDesignPermitActivationDateEntryTableAdapters.QueriesTableAdapter aUpdateDesignPermitActivationDateTableAdapter;

        UpdateDesignPermitClosedDateEntryTableAdapters.QueriesTableAdapter aUpdateDesignPermitClosedDateTableAdapter;

        UpdateDesignPermitCommentsEntryTableAdapters.QueriesTableAdapter aUpdateDesignPermitCommentsTableAdapter;

        UpdateDesignProjectActiveEntryTableAdapters.QueriesTableAdapter aUpdateDesignProjectActiveTableAdapter;

        findAllOpenDesignPermitImportsDataSet aFindAllOpenDesignPermitImportsDataSet;
        findAllOpenDesignPermitImportsDataSetTableAdapters.FindAllOpenDesignPermitImportsTableAdapter aFindAllOpenDesignPermitImportsTableAdapter;

        FindDesignPermitImportByAssignedProjectIDDataSet aFindDesignPermitImportByAssignedProjectIDDataSet;
        FindDesignPermitImportByAssignedProjectIDDataSetTableAdapters.FindDesignPermitImportByAssignedProjectIDTableAdapter aFindDesignPermitImportByAssignedProjectIDTableAdapter;

        UpdateDesignPermitImportNotesTableAdapters.QueriesTableAdapter aUpdateDesignPermitImportNotesTableAdapter;

        public bool UpdateDesignPermitImportNotes(int intTransactionID, string strPermitComments)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignPermitImportNotesTableAdapter = new UpdateDesignPermitImportNotesTableAdapters.QueriesTableAdapter();
                aUpdateDesignPermitImportNotesTableAdapter.UpdateDesignPermitImportNotes(intTransactionID, strPermitComments);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Import Notes " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindDesignPermitImportByAssignedProjectIDDataSet FindDesignPermitImportByAssignedProjectID(string strAssignedProjectID)
        {
            try
            {
                aFindDesignPermitImportByAssignedProjectIDDataSet = new FindDesignPermitImportByAssignedProjectIDDataSet();
                aFindDesignPermitImportByAssignedProjectIDTableAdapter = new FindDesignPermitImportByAssignedProjectIDDataSetTableAdapters.FindDesignPermitImportByAssignedProjectIDTableAdapter();
                aFindDesignPermitImportByAssignedProjectIDTableAdapter.Fill(aFindDesignPermitImportByAssignedProjectIDDataSet.FindDesignPermitImportByAssignedProjectID, strAssignedProjectID);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Find Design Permit Import By Assigned Project ID " + Ex.Message);
            }

            return aFindDesignPermitImportByAssignedProjectIDDataSet;
        }
        public findAllOpenDesignPermitImportsDataSet FindAllOpenDesignPermitImports()
        {
            try
            {
                aFindAllOpenDesignPermitImportsDataSet = new findAllOpenDesignPermitImportsDataSet();
                aFindAllOpenDesignPermitImportsTableAdapter = new findAllOpenDesignPermitImportsDataSetTableAdapters.FindAllOpenDesignPermitImportsTableAdapter();
                aFindAllOpenDesignPermitImportsTableAdapter.Fill(aFindAllOpenDesignPermitImportsDataSet.FindAllOpenDesignPermitImports);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Find All Open Design Permit Imports " + Ex.Message);
            }

            return aFindAllOpenDesignPermitImportsDataSet;
        }
        public bool UpdateDesignProjectActive(int intTransactionID, bool blnProjectActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignProjectActiveTableAdapter = new UpdateDesignProjectActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignProjectActiveTableAdapter.UpdateDesignProjectActive(intTransactionID, blnProjectActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Project Active " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignPermitComments(int intTransactionID, string strPermitComments)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignPermitCommentsTableAdapter = new UpdateDesignPermitCommentsEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignPermitCommentsTableAdapter.UpdateDesignPermitComments(intTransactionID, strPermitComments);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Comments " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignPermitClosedDate(int intTransactionID, DateTime datPermitClosedDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignPermitClosedDateTableAdapter = new UpdateDesignPermitClosedDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignPermitClosedDateTableAdapter.UpdateDesignPermitClosedDate(intTransactionID, datPermitClosedDate);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Closed Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignPermitActivationDate(int intTransactionID, DateTime datActivationDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignPermitActivationDateTableAdapter = new UpdateDesignPermitActivationDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignPermitActivationDateTableAdapter.UpdateDesignPermitActivationDate(intTransactionID, datActivationDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Activation Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignPermitExpirationDate(int intTransactionID, DateTime datPermitExpiration)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignPermitExpirationDateTableAdapter = new UpdateDesignPermitExpirationDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignPermitExpirationDateTableAdapter.UpdateDesignPermitExperationDate(intTransactionID, datPermitExpiration);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Expiration Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignPermitApproval(int intTransactionID, DateTime datPermitApproved)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignPermitApprovalTableAdapter = new UpdateDesignPermitApprovalEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignPermitApprovalTableAdapter.UpdateDesignPermitApproval(intTransactionID, datPermitApproved);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Approval " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateDesignPermitSubmitted(int intTransactionID, DateTime datPermitSubmitted)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignPermitSubmittedTableAdapter = new UpdateDesignPermitSubmittedEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignPermitSubmittedTableAdapter.UpdateDesignPermitSubmitted(intTransactionID, datPermitSubmitted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Submitted " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindDesignPermitImportByTransactionDateDataSet FindDesignPermitImportbyTransactionDate(DateTime datTransactionDate)
        {
            try
            {
                aFindDesignPermitImportbyTransactionDateDataSet = new FindDesignPermitImportByTransactionDateDataSet();
                aFindDesignPermitImportByTransactionDateTableAdapter = new FindDesignPermitImportByTransactionDateDataSetTableAdapters.FindDesignPermitImportByTransactionDateTableAdapter();
                aFindDesignPermitImportByTransactionDateTableAdapter.Fill(aFindDesignPermitImportbyTransactionDateDataSet.FindDesignPermitImportByTransactionDate, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permits Class // Find Design Permit Import by Transaction Date " + Ex.Message);
            }

            return aFindDesignPermitImportbyTransactionDateDataSet;
        }
        public bool InsertDesignPermitImport(int intProjectID, string strCarlID, string strSurveyType, string strJobName, string strFieldEngineer, string strConstSupervisor, string strPermitType, DateTime datIssueDate, string strPermitAgency, DateTime datTransactionDate, string strPermitComment)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDesignPermitImportTableAdapter = new InsertDesignPermitImportEntryTableAdapters.QueriesTableAdapter();
                aInsertDesignPermitImportTableAdapter.InsertDesignPermitImport(intProjectID, strCarlID, strSurveyType, strJobName, strFieldEngineer, strConstSupervisor, strPermitType, datIssueDate, strPermitAgency, datTransactionDate, strPermitComment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Insert Design Permit Import " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DesignPermitImportDataSet GetDesignPermitImportInfo()
        {
            try
            {
                aDesignPermitImportDataSet = new DesignPermitImportDataSet();
                aDesignPermitImportTableAdapter = new DesignPermitImportDataSetTableAdapters.designpermitimportTableAdapter();
                aDesignPermitImportTableAdapter.Fill(aDesignPermitImportDataSet.designpermitimport);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Get Design Permit Import Info " + Ex.Message);
            }

            return aDesignPermitImportDataSet;
        }
        public void UpdateDesignPermitImportDB(DesignPermitImportDataSet aDesignPermitImportDataSet)
        {
            try
            {
                aDesignPermitImportTableAdapter = new DesignPermitImportDataSetTableAdapters.designpermitimportTableAdapter();
                aDesignPermitImportTableAdapter.Update(aDesignPermitImportDataSet.designpermitimport);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Permit Import DB " + Ex.Message);
            }
        }
        public bool UpdateDesignProjectPermitCost(int intTransactionID, decimal decPermitCost, decimal decPermitPrice)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDesignProjectPermitCostTableAdapter = new UpdateDesignProjectPermitCostEntryTableAdapters.QueriesTableAdapter();
                aUpdateDesignProjectPermitCostTableAdapter.UpdateDesignProjectPermitCost(intTransactionID, decPermitCost, decPermitPrice);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Design Permit Class // Update Design Project Permit Cost " + Ex.Message);


                blnFatalError = true;
            }

            return blnFatalError;
        }
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
