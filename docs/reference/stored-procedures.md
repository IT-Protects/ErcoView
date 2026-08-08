# Reference: stored procedures

Inferred from client code and `dsErcoView.xsd`. Confirm definitions on SQL Server.

## Auth and users

| Procedure | Direction | Caller area |
|-----------|-----------|-------------|
| `spLogin` | R | `clsLogon` |
| `spUpdatePassword` | W | `frmSettings` |
| `spGetUsers` | R | Users grid/form |
| `spGetUserById` | R | `Utils` |
| `spInsertUser` | W | `clsFrmUsers` |
| `spUpdateUser` | W | `clsFrmUsers` |
| `spGetPermissions` | R | User form |

## Proposals

| Procedure | Direction | Caller area |
|-----------|-----------|-------------|
| `spGetProposals` | R | Main grid, reports, hot seat |
| `spGetNewProposalNumber` | R | `modMain` |
| `spInsertProposal2` | W | `clsFrmProposal` |
| `spInsertProposal3` | W | Legacy/commented path |
| `spUpdateProposal` | W | `clsFrmProposal` |
| `spGetProposalsByMonth` | R | Report |

### Proposal party helpers

| Procedure | Role |
|-----------|------|
| `spGetSalesmanOfProposalId` | Read salesman slots |
| `spGetCustomerOfProposalId` | Read customer slots |
| `spGetContactOfProposalId` | Read contact slots |
| `spGetVendorOfProposalId` | Read vendor slots |
| `spGetSuperOfProposalId` | Read super slots |
| `spGetJobTypeOfProposalId` | Read job type slots |
| `spGetSBSOfProposalId` | Read SBS |
| `spSetSalesman` / `spDeleteSalesman` | Maintain salesman links |
| `spSetSuper` / `spDeleteSuper` | Super links |
| `spSetContact` / `spSetCustomer` / `spSetGroup` / `spSetVendor` | Set links |
| `spDeleteCompanyFromProposal` | Shared delete path in list UI |
| `spSetJobTypes` / `spDeleteJobTypes` | Job types on proposal |

## Customers, vendors, contacts, groups

| Procedure | Direction |
|-----------|-----------|
| `spGetCustomer` / `spGetCustomers` | R |
| `spGetCustomerById` | R |
| `spInsertCustomer` / `spUpdateCustomer` | W |
| `spGetVendor` / `spGetVendors` | R |
| `spGetVendorById` | R |
| `spGetContact` / `spGetContacts` | R |
| `spGetContactById` | R |
| `spInsertContact` / `spUpdateContact` | W |
| `spGetGroups` | R |
| `spInsertGroup` | W |
| `spGetGroupOfCustomerId` | R |

## Lookups

| Procedure | Direction |
|-----------|-----------|
| `spGetSalesman` / `spGetSalesmanById` | R |
| `spGetSuper` / `spGetSuperById` | R |
| `spGetJobTypes` / `spGetJobNameById` | R |
| `spGetJobNumbers` | R |
| `spGetNewJobNumber` | R |
| `spUpdateJobNumber` | W |

## Reports

| Procedure | Typical parameters |
|-----------|-------------------|
| `spGetBookings` | year, month |
| `spRptCompletedPrj` | year |
| `spRptConstSch` | (see adapter) |
| `spRptConstSch2` | year |
| `spReportRevenueByMonth` | year range style params |
| `spGetProposalsByMonth` | month/year style params |

## Adding a new SP (client checklist)

1. Create/alter SP on **Training**.  
2. Decide TableAdapter vs ad-hoc `SqlCommand`.  
3. If TableAdapter: update `dsErcoView.xsd`.  
4. Wire connection via `GetConnectionString()`.  
5. Document here and in domain/architecture if user-visible.  
6. Promote SQL to Live under change control.

## Not in repo

Procedure **bodies**, grants, indexes, and triggers—export from SQL Server into a future `db/` tree if you need offline review.
