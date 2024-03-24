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