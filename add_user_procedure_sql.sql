create proc add_user

@id int , 
  @account_number NUMERIC,
    @name          VARCHAR,
    @address        VARCHAR,
    @account_type   INT,
    @balance       NUMERIC,
    @aadhar_card    NUMERIC,
    @password       VARCHAR
AS
if @id=0
begin
insert into user_table(account_number , name , address , account_type , balance , aadhar_card , password)
values(@account_number , @name , @address , @account_type , @balance , @aadhar_card , @password)
end

 
