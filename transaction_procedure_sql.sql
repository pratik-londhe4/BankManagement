CREATE proc new_transaction

    @timestamp    DATETIME,
    @amount      NUMERIC (18),
    @debited_from NUMERIC (18),
    @credited_to  NUMERIC (18)
   
AS
begin
insert into transactions(timestamp , amount , debited_from , credited_to)
values( @timestamp , @amount , @debited_from , @credited_to)
update user_table
set balance = balance + @amount where account_number = @credited_to

update user_table
set balance = balance - @amount where account_number = @debited_from
end