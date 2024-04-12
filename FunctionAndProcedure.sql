use groupProject

create function validateLogin
(
	@input_id int,
	@input_password varchar(50)
)
returns bit
as
begin
	declare @isValid bit = 0
	if exists(
		select 1 from users 
		where user_id=@input_id
		and password=@input_password
	)
	begin 
		set @isValid=1
	end
	return @isValid
end

select dbo.validateLogin(1,'password')

CREATE PROCEDURE updateOrInsertInvoiceDetails
    @invoiceId INT,
    @foodId INT,
    @quantity INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @existingRows INT;
    SELECT @existingRows = COUNT(*) FROM invoice_details WHERE invoice_id = @invoiceId AND food_id = @foodId;

    IF @existingRows > 0
    BEGIN
        UPDATE invoice_details
        SET quantity = @quantity
        WHERE invoice_id = @invoiceId AND food_id = @foodId;
    END
    ELSE
    BEGIN
        INSERT INTO invoice_details (invoice_id, food_id, quantity)
        VALUES (@invoiceId, @foodId, @quantity);
    END
END;

select * from invoice_details;
EXEC updateOrInsertInvoiceDetails @invoiceId = 1, @foodId = 3, @quantity = 12;

CREATE FUNCTION GetTotalMoneyForMonth(@Year INT, @Month INT)
RETURNS MONEY
AS
BEGIN
    DECLARE @TotalMoney MONEY;

    SELECT 
        @TotalMoney = ISNULL(SUM(total_money), 0)
    FROM 
        invoices
    WHERE 
        DATEPART(YEAR, invoice_date) = @Year AND
        DATEPART(MONTH, invoice_date) = @Month;

    RETURN @TotalMoney;
END;


SELECT dbo.GetTotalMoneyForMonth(2024, 1);
