CREATE FUNCTION udf_GetRadians(@Degrees FLOAT)
RETURNS FLOAT
AS
BEGIN
RETURN @Degrees*pi()/180
END