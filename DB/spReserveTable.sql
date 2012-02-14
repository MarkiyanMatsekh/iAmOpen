USE [IAmOpen.OnlineReservations]
GO
/****** Object:  StoredProcedure [dbo].[spReserveTable]    Script Date: 12/03/2011 13:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spReserveTable] 
	@TableID int,
	@UserID int,
	@ReservationTime datetime
AS
BEGIN
	SET NOCOUNT ON;

    return 20;
END
