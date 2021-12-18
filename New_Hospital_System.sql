	--Create database called GUI_Hospital_Management_System

	CREATE DATABASE GUI_Hospital_Management_System 

	USE GUI_Hospital_Management_System;
	   

	--CREATE TABLE ACCOUNT

	--**********************************************
	--			Execute 1
	--**********************************************

	CREATE TABLE ACCOUNT
	(
		Num						INT		IDENTITY (1,1)  NOT NULL, 

		Roll_Id AS 'R' + RIGHT('000' + CAST (Num AS VARCHAR(7)),7) PERSISTED,	

		Roll_Name               VARCHAR (80)			NOT NULL,
		Login_Username			VARCHAR (50)			NOT NULL, 
		Login_Password			VARCHAR (20)			NOT NULL,
		E_mail					VARCHAR (90)					,
		A_Create_Date			DATE							,
		A_Create_Time			TIME							,

		CONSTRAINT pk_ACCOUNT PRIMARY KEY (Roll_Id)
	);

	SELECT * FROM ACCOUNT;
	SELECT * FROM LOG_IN_USER;

	--CREATE TABLE LOG IN USER

	--**********************************************
	--			Execute 2
	--**********************************************

	CREATE TABLE LOG_IN_USER
	(
		Roll_Id					VARCHAR ( 8)	NOT NULL,
		Roll_name               VARCHAR (80)			,
		First_Name				VARCHAR (100)	NOT NULL,
		Middle_Name				VARCHAR (100)			,
		Surname					VARCHAR (100)	NOT NULL,
		User_Address			VARCHAR (100)			,
		Img                     IMAGE					,
		Gender					VARCHAR (10)			,
		User_Tele_No			INT						,
		Date_Of_Birth			DATE					,						
		Designation				VARCHAR (50)			,
		Salary					DECIMAL					,
		 
		CONSTRAINT pk_LOG_IN_USER PRIMARY KEY (Roll_Id),
		CONSTRAINT fk_LOG_IN_USER FOREIGN KEY (Roll_Id) REFERENCES ACCOUNT 
		ON DELETE CASCADE
	);
	

	 --INSERT VALUES INTO ACCOUNT AND LOG IN USER TABLES USING STORED PROCEDURE

	CREATE PROCEDURE ACCOUNT_LOG_IN_USER
	(
		@Action			            VARCHAR (10) ,
		@Num						INT			 , 
		@Roll_Id                    VARCHAR (8)  ,	
		@Roll_Name					VARCHAR (80) ,
		@Login_Username				VARCHAR (50) , 
		@Login_Password				VARCHAR (20) ,
		@E_mail						VARCHAR (90) ,
		@A_Create_Date				DATE         ,
		@A_Create_Time				TIME         ,
		@R_Id						VARCHAR ( 8) ,
		@First_Name					VARCHAR (100),
		@Middle_Name				VARCHAR (100),
		@Surname					VARCHAR (100),
		@User_Address				VARCHAR (100),
		@Img						IMAGE        ,
		@Gender						VARCHAR (10) ,
		@User_Tele_No				INT			 ,
		@Date_Of_Birth				DATE         ,						
		@Designation				VARCHAR (50) ,
		@Salary						DECIMAL		 
	)

	AS
	IF @Action='INSERT'
	BEGIN

	INSERT INTO ACCOUNT
	SELECT 	@Roll_Name, @Login_Username, @Login_Password, @E_mail,  @A_Create_Date, @A_Create_Time

	INSERT INTO LOG_IN_USER
	SELECT @R_Id,@Roll_Name,@First_Name,@Middle_Name,@Surname, @User_Address, @Img, @Gender, @User_Tele_No,
	       @Date_Of_Birth, @Designation, @Salary
 
	END
	GO	

			
	--Billing Officer

	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'BILLING_OFFICER', 'BILSANDUNI'  , 'KI7431DHDF', ' ', ' ', ' ', 'R0001' , 'SADUNI', 'MALSHA', 'DISSANAYAKA'    ,  'KELANIYA'  , ' ',  'FEMALE' , 0717878678, '1996.05.17', 'BILLING_OFFICER', '54000.50'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'BILLING_OFFICER', 'BILMALEESH'  , 'F54FJYRCBJ', ' ', ' ', ' ', 'R0002' , 'MALEESHA','PRAMOD','WANIGASINGHE' ,  'GAMPAHA'   , ' ',  'MALE'   , 0772323123, '1994.10.22', 'BILLING_OFFICER', '53000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'BILLING_OFFICER', 'BILCHARITH'  , '0909NJG65B', ' ', ' ', ' ', 'R0003' , 'CHARITHA', 'PEIRIS', 'JAYAWARDHANA' ,  'PANADURA'  , ' ',  'FEMALE' , 0718989765, '1986.02.14', 'BILLING_OFFICER', '51000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'BILLING_OFFICER', 'BILHIRUNIC'  , 'S86BC642CY', ' ', ' ', ' ', 'R0004' , 'HIRUNI', 'VIDUMINI', 'RATHNAYAKA'   ,  'TANGALLE'  , ' ',  'FEMALE' , 0716565345, '1998.05.19', 'BILLING_OFFICER', '44000.50'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'BILLING_OFFICER', 'BILHASINIQ'  , '097VFDEWH6', ' ', ' ', ' ', 'R0005' , 'HASINI',' CHANCHALA', 'JAYAKODI'    ,  'COLOMBO'   , ' ',  'FEMALE' , 0772123123, '1990.03.17', 'BILLING_OFFICER', '53500.50'
	
	--Channeling Officer

	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'CHANNELING_OFFICER', 'CHANSANJU'  , 'SANJU12341', ' ', ' ', ' ', 'R0006' , 'SANJU', 'NILUKSHAN', 'DISSANAYAKA'      , 'COLOMBO'  , ' ',  'MALE'  , 0712123125, '1990.10.10', 'CHANNELING OFFICER', '45000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'CHANNELING_OFFICER', 'CHANRANGI'  , 'RANGIPRIYA', ' ', ' ', ' ', 'R0007' , 'RANGI', ' PRIYADARSHANI', ' RATHNAYAKA'   , 'COLOMBO'  , ' ',  'FEMALE', 0771245456, '1998.09.25', 'CHANNELING OFFICER', '45000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'CHANNELING_OFFICER', 'CHANTHUSH'  , 'THUSHDASA1', ' ', ' ', ' ', 'R0008' , 'THUSHARI', '', 'DASANAYAKA'			   , 'KALUTARA' , ' ',  'FEMALE', 0712123125, '1990.10.10', 'CHANNELING OFFICER', '45000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'CHANNELING_OFFICER', 'CHANSARAN'  , 'SARANGA123', ' ', ' ', ' ', 'R0009' , 'SARANGA', ' RANGANATH', ' PEIRIS'         , 'MATARA'   , ' ',  'MALE'  , 0768989098, '1887.01.13', 'CHANNELING OFFICER', '45000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'CHANNELING_OFFICER', 'CHANNILAN'  , '123NILANTH', ' ', ' ', ' ', 'R00010', 'NILANTHI', ' DILRUKSHI', ' RAMASINGHE'    , 'GALLE'    , ' ',  'FEMALE', 0717878654, '1970.09.12', 'CHANNELING OFFICER', '45000.00'
	
	
	--ADMISSION OFFICER--
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'ADMISSION_OFFICER', 'ADACHIN122'  , '123@HF8646', ' ', ' ', ' ', 'R00011' , 'ACHIN', ' SUDHARAKA', ' WIKRAMASINGHE', 'TANGALLE'  , ' ',  'MALE'   , 0717575643, '1996.06.19', 'ADMISSION_OFFICER', '44000.50'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'ADMISSION_OFFICER', 'ADSACHINI1'  , '9H5D431SAD', ' ', ' ', ' ', 'R00012' , 'SACHINI', ' SASHIKALA', ' PEIRIS'     , 'MATARA'    , ' ',  'FEMALE' , 0778787545, '1995.02.16', 'ADMISSION_OFFICER', '45000.50'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'ADMISSION_OFFICER', 'ADSANKA65I'  , '8907GFDARH', ' ', ' ', ' ', 'R00013' , 'SANKA', ' DINELKA ', 'GUNASEKARA'     , 'PANADURA'  , ' ',  'MALE'   , 0768771231, '1986.01.29', 'ADMISSION_OFFICER', '49000.50'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'ADMISSION_OFFICER', 'ADAYOMI123'  , 'S90MGCDYNU', ' ', ' ', ' ', 'R00014' , 'AYOMI', ' HARSHANI ', 'GUNADASA'      , 'MORATUWA'  , ' ',  'FEMALE' , 0713434787, '1989.05.19', 'ADMISSION_OFFICER', '42000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'ADMISSION_OFFICER', 'ADCHATHURA'  , 'LIKU76543D', ' ', ' ', ' ', 'R00015' , 'CHATHURA', ' MALITH', ' DASANAYAKA'   , 'HOMAGAMA'  , ' ',  'MALE'   , 0760098090, '1998.08.21', 'ADMISSION_OFFICER', '41000.50' 
	 

	--WARD--
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'WARD_STAFF', 'WARDMEM1'  , 'ACHINSUDHARK', ' ', ' ', ' ', 'R00016'  , 'ACHIN', ' SUDHARAKA ', 'WIKRMASINGHE'   ,  'TANGALLE' , ' ',  'MALE'   , 0717575643, '1996.06.19', 'NURSE' , '44000.50' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'WARD_STAFF', 'WARDMEM2'  , 'SACHINI12D34', ' ', ' ', ' ', 'R00017'  , 'SACHINI', ' SASHIKALA ', 'PEIRIS'       ,  'MATARA'   , ' ',  'FEMALE' , 0778787545, '1995.02.16', 'NURSE' , '45000.50'
	
	--PHARM--
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'PHARMACY_STAFF', 'PHARMMEM1'  , '87421LKJLH', ' ', ' ', ' ', 'R00018'  , 'SANKA', ' DINELKA', ' GUNASEKARA'   ,  'PANADURA'  , ' ',  'MALE'   , 0768771231, '1986.01.29', 'PHARMACIAN' , '49000.50'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'PHARMACY_STAFF', 'PHARMMEM2'  , 'SAAYOM12B3', ' ', ' ', ' ', 'R00019'  , 'AYOMI ', 'HARSHANI', ' GUNADASA'    ,  'MORATUWA'  , ' ',  'FEMALE' , 0713434787, '1989.05.19', 'PHARMACIAN' , '42000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'PHARMACY_STAFF', 'PHARMMEM13' , 'KALUN2312D', ' ', ' ', ' ', 'R00020'  , 'CHATHURA', ' MALITH ', 'DASANAYAKA' ,  'HOMAGAMA'  , ' ',  'MALE'   , 0760098090, '1998.08.21', 'PHARMACIAN' , '41000.50' 
	
	--LABORATORY--
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'LABORATORY_STAFF', 'LABMEM1'  , '12FGR453ASDD', ' ', ' ', ' ', 'R00021'  , 'ACHIN', ' SUDHARAKA ', 'WIKRMASINGHE'   ,  'TANGALLE' , ' ',  'MALE'   , 0717575643, '1996.06.19', 'ASSISTANT LABORATORIAN' , '49000.50'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'LABORATORY_STAFF', 'LABMEM2'  , 'HOSTR4E3W21W', ' ', ' ', ' ', 'R00022'  , 'SACHINI', ' SASHIKALA ', 'PEIRIS'       ,  'MATARA'   , ' ',  'FEMALE' , 0778787545, '1995.02.16', 'LABORATORIAN'           , '42000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'LABORATORY_STAFF', 'LABMEM2'  , 'SASHOSLAB190', ' ', ' ', ' ', 'R00023'  , 'SACHINI', ' SASHIKALA ', 'PEIRIS'       ,  'MATARA'   , ' ',  'FEMALE' , 0778787545, '1995.02.16', 'ASSISTANT LABORATORIAN' , '41000.50'
	
	--SCAN ROOM--
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'SCAN_ROOM', 'SC12MEM1'  , 'WAYOMI2346', ' ', ' ', ' ', 'R00024' , 'WAYOMI', ' NISANSALA', ' DAHANAYAKA'  ,  'TANGALLE' , ' ',  'FEMALE' , 0717575643, '1996.06.19', 'RADIOLOGY' ,'54000.50' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'SCAN_ROOM', 'SC12MEM2'  , 'MADAWA1009', ' ', ' ', ' ', 'R00025' , 'MADAWA ', 'SASHIKA', ' PERERA'        ,  'MATARA'   , ' ',  'MALE'   , 0778787545, '1995.02.16', 'RADIOLOGY' ,'87000.50' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'SCAN_ROOM', 'SC12MEM3'  , 'NALIN65430', ' ', ' ', ' ', 'R00026' , 'NALIN ', 'NIMALKA', ' DISANAYAKA'     ,  'PANADURA' , ' ',  'MALE'   , 0768771231, '1986.01.29', 'RADIOLOGY' ,'59000.50' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'SCAN_ROOM', 'SC12MEM4'  , 'NISHADI980', ' ', ' ', ' ', 'R00027' , 'NISHADI ', 'HANSANI ', 'WARNASEKARA'  ,  'MORATUWA' , ' ',  'FEMALE' , 0713434787, '1989.05.19', 'RADIOLOGY' ,'52000.00' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'SCAN_ROOM', 'SC12MEM5'  , 'CHATHURA00', ' ', ' ', ' ', 'R00028' , 'CHATHURA', ' SACHITH ', 'JAYASEKARA'  ,  'HOMAGAMA' , ' ',  'FEMALE' , 0760098090, '1998.08.21', 'RADIOLOGY' ,'51000.50' 

	--X-RAY-ROOM--

	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'XRAY_ROOM', 'XR12MEM1'  , 'LKLKHYT632', ' ', ' ', ' ', 'R00029' , 'WAYOMI', ' NISANSALA', ' DAHANAYAKA'  ,  'TANGALLE' , ' ',  'FEMALE' , 0717575643, '1996.06.19', 'RADIOLOGY' ,'54000.50' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'XRAY_ROOM', 'XR12MEM2'  , 'LKHFUY763H', ' ', ' ', ' ', 'R00030' , 'MADAWA', ' SASHIKA ', 'PERERA'        ,  'MATARA'   , ' ',  'MALE'   , 0778787545, '1995.02.16', 'RADIOLOGY' ,'87000.50' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'XRAY_ROOM', 'XR12MEM3'  , '09KJG54GSG', ' ', ' ', ' ', 'R00031' , 'NALIN', ' NIMALKA', 'DISANAYAKA'      ,  'PANADURA' , ' ',  'MALE'   , 0768771231, '1986.01.29', 'RADIOLOGY' ,'59000.50' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'XRAY_ROOM', 'XR12MEM4'  , 'NIHGY65412', ' ', ' ', ' ', 'R00032' , 'NISHADI', ' HANSANI', ' WARNASEKARA'  ,  'MORATUWA' , ' ',  'FEMALE' , 0713434787, '1989.05.19', 'RADIOLOGY' ,'52000.00' 
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'XRAY_ROOM', 'XR12MEM5'  , 'HU653VSJ6V', ' ', ' ', ' ', 'R00033' , 'CHATHURA', ' SACHITH', ' JAYASEKARA'  ,  'HOMAGAMA' , ' ',  'FEMALE' , 0760098090, '1998.08.21', 'RADIOLOGY' ,'51000.50' 
		
	--DOCTORS--
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'DOCTOR', 'DOCDILRUKSHI', 'RUBERU1212', ' ', ' ', ' ', 'R00034', 'DILRUKSHI ', 'UPAMALI', ' RUBERU' , 'COLOMBO', ' ', 'FEMALE'   , 0712343123, '1978.10.09', 'DOCTOR', '123000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'DOCTOR', 'DOCKOSALA'   , 'LOSALA45DO', ' ', ' ', ' ', 'R00035', 'KOSALA', '', ' KARUNARATHNA'      , 'COLOMBO', ' ', 'MALE'     , 0765421098, '1982.09.07', 'DOCTOR', '212000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'DOCTOR', 'DOCHAREND'   , 'HARENDRAQ1', ' ', ' ', ' ', 'R00036', 'HARENDRA', ' DE', ' SILVA'        , 'COLOMBO', ' ', 'MALE'     , 0765980098, '1973.08.11', 'DOCTOR', '212000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'DOCTOR', 'DOCSANJAYA'  , 'SANJAYA123', ' ', ' ', ' ', 'R00037', 'SANJAYA', '', ' ABAGUNAWARDANA'   , 'COLOMBO', ' ', 'MALE'     , 0712398532, '1976.02.18', 'DOCTOR', '240000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'DOCTOR', 'LOSALA45DO'  , 'WARUNA2312', ' ', ' ', ' ', 'R00038', 'WARUNA ', 'NAMALI', ' LIYANAGE'   , 'GAMPAHA', ' ', 'MALE'     , 0704376311, '1990.10.11', 'DOCTOR', '112000.00'
	EXECUTE ACCOUNT_LOG_IN_USER 'INSERT', ' ', ' ', 'DOCTOR', 'LOSALA45DO'  , 'WARUNA2312', ' ', ' ', ' ', 'R00039', 'WARUNA ', 'NAMALI', ' LIYANAGE'   , 'GAMPAHA', '', 'MALE'     , 0704376311, '1990.10.11', 'DOCTOR', '112000.00'
		
		
		SELECT*
		FROM ACCOUNT

		SELECT*
		FROM LOG_IN_USER

		SELECT *
		FROM ACCOUNT, LOG_IN_USER
		WHERE ACCOUNT.Roll_Id= LOG_IN_USER.Roll_Id


	--CREATE TABLE WARD

	--**********************************************
	--			Execute 3
	--**********************************************

	CREATE TABLE WARD
	(
		Ward_Number						CHAR    (10)                      NOT NULL ,
		Ward_Name	                    VARCHAR (70)                      NOT NULL ,

		CONSTRAINT pk_WARD PRIMARY KEY ( Ward_Number )
	);

	SELECT * FROM WARD

	--CREATE TABLE ROOM 

	--**********************************************
	--			Execute 4
	--**********************************************

	CREATE TABLE ROOM
	(
		Room_Number						CHAR    (10)                      NOT NULL,
		Room_Name                       VARCHAR (70)                      NOT NULL,
		Room_Type						VARCHAR (90)                      NOT NULL,
		Room_Availability               CHAR    (10)                      NOT NULL, 
		Ward_Number						CHAR    (10)                      NOT NULL,
	                 
		CONSTRAINT pk_ROOM PRIMARY KEY ( Room_Number ) ,
		CONSTRAINT fk_ROOM FOREIGN KEY ( Ward_Number ) REFERENCES WARD 
		ON DELETE CASCADE
	);

	SELECT Room_Availability FROM ROOM WHERE Room_Availability='YES'
	SELECT Room_Availability FROM ROOM WHERE Room_Availability='NO'

	SELECT * FROM ROOM

	--INSERT VALUES INTO ROOM AND WARD TABLES USING A STORED PROCEDURE

	CREATE PROCEDURE ROOM_WARD
	(
		@Action					VARCHAR (10) ,
		@Ward_Number			CHAR    (10) ,
		@Ward_Name	            VARCHAR (70) ,                     
		@Room_Number			CHAR    (10) ,
		@Room_Name              VARCHAR (70) ,
		@Room_Type				VARCHAR (90) ,
		@Room_Availability      CHAR    (10)  			
							
	)
		AS 
		IF @Action = 'INSERT'
		BEGIN
		INSERT INTO WARD
		SELECT @Ward_Number , @Ward_Name

		INSERT INTO ROOM
		SELECT @Room_Number , @Room_Name , @Room_Type , @Room_Availability , @Ward_Number
		END
		GO

		EXECUTE ROOM_WARD 'INSERT' , 'W01' , 'PAEDIATRIC'  , 'R001' , ' SUPERIOR ' , 'AC'	  , 'YES' ;
		EXECUTE ROOM_WARD 'INSERT' , 'W02' , 'SURGERY'	   , 'R003' , ' HERITAGE ' , 'NON AC' , 'NO'  ;
		EXECUTE ROOM_WARD 'INSERT' , 'W03' , 'ORTHROPEDIC' , 'R004' , ' SUPERIOR ' , 'AC'	  , 'YES' ;
		EXECUTE ROOM_WARD 'INSERT' , 'W04' , 'CARDIAC'     , 'R006' , ' INTERIOR ' , 'NON AC' , 'NO'  ;
	
		INSERT INTO ROOM VALUES('R002','INTERIOR','NON AC','YES','W01')
		INSERT INTO ROOM VALUES('R005','HERITAGE','NON AC','YES','W02')

		SELECT*
		FROM ROOM

		SELECT*
		FROM WARD

		SELECT *
		FROM ROOM,WARD
		WHERE ROOM.Ward_Number=WARD.Ward_Number


	--CREATE TABLE SPECIALIST DOCTOR

	--**********************************************
	--			Execute 5
	--**********************************************
		
	CREATE TABLE SPECIALIST_DOCTOR
	(	
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Specialist_Doctor_Id AS 'SD' + RIGHT ('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		SLMC_Reg_Number					CHAR    (20)			NOT NULL UNIQUE,
		Title							VARCHAR (10)			NOT NULL,
		S_Doctor_Name					VARCHAR (50)			NOT NULL,
		S_Field							VARCHAR (20)            NOT NULL,
		S_Doctor_Type					CHAR    (20)			NOT NULL,
		S_Doctor_Address				VARCHAR (100)			NOT NULL,
		S_Doctor_Tele_Number			INT                     NOT NULL,
		S_Doctor_Monthly_Salary			DECIMAL                 NOT NULL,
		S_Doctor_Job_Start_Date			DATE					NOT NULL,
		Ward_Number						CHAR    (10)            NOT NULL,

		CONSTRAINT pk_SPECIALIST_DOCTOR PRIMARY KEY ( Specialist_Doctor_Id ),
		CONSTRAINT fk_SPECIALIST_DOCTOR FOREIGN KEY ( Ward_Number ) REFERENCES WARD
		ON DELETE CASCADE
	);

	SELECT * FROM SPECIALIST_DOCTOR;

	--CREATE TABLE FOR SPECIALIST DOCTOR QUALIFICATION

	--**********************************************
	--			Execute 6
	--**********************************************

	CREATE TABLE QUALIFICATION
	(
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,
		Qualification					VARCHAR (20)			NOT NULL,

		CONSTRAINT pk_QUALIFICATION PRIMARY KEY ( Specialist_Doctor_Id , Qualification  ),
		CONSTRAINT fk_QUALIFICATION FOREIGN KEY ( Specialist_Doctor_Id ) REFERENCES SPECIALIST_DOCTOR 
		ON DELETE CASCADE
	);

	--INSERT VALUES INTO SPECIALIST DOCTOR TABLE AND QUALIFICATION TABLE USING STORED PROCEDURE

	CREATE PROCEDURE DOCTOR_QUALIFICATION
		(	
		@Action						VARCHAR (10) ,	
		@Number						INT          ,	
		@Specialist_Doctor_Id		VARCHAR (9)  ,
		@SLMC_Reg_Number			VARCHAR (20) ,
		@Title						VARCHAR (10) ,
		@S_Doctor_Name				VARCHAR (50) ,
		@S_Field					VARCHAR (20) ,
		@S_Doctor_Type				CHAR    (20) ,
		@S_Doctor_Address			VARCHAR (100),
		@S_Doctor_Tele_Number		CHAR	(10) ,
		@S_Doctor_Monthly_Salary	INT          ,
		@S_Doctor_Job_Start_Date	DATE		 ,
		@Ward_Number				CHAR    (10) ,
		@Specialist_Id 			    VARCHAR (9)	 ,
		@Qualification				CHAR    (20)						
		)
		AS

		IF @ACTION = 'INSERT'
		BEGIN

		INSERT INTO  SPECIALIST_DOCTOR
		SELECT @SLMC_Reg_Number,@Title	,@S_Doctor_Name,@S_Field,@S_Doctor_Type,@S_Doctor_Address,
		@S_Doctor_Tele_Number,@S_Doctor_Monthly_Salary,@S_Doctor_Job_Start_Date,@Ward_Number

		INSERT INTO QUALIFICATION
		SELECT @Specialist_Id , @Qualification
		END
		GO

		EXECUTE DOCTOR_QUALIFICATION 'INSERT' , ' ' , ' ' ,'SLMC0001' , 'MRS', 'DILRUKSHI RUBERU'       ,'PAEDIATRICIAN'      ,'RESIDENT' ,'COLOMBO' ,0718603403 ,220000 ,'2010.09.10' ,'W01' ,'SD0001' ,'MBBS'
		EXECUTE DOCTOR_QUALIFICATION 'INSERT' , ' ' , ' ' ,'SLMC0002' , 'MR' , 'KOSALA KARUNARATHNA'    ,'PAEDIATRICIAN'      ,'VISITING' ,'COLOMBO' ,0777676512 ,190000 ,'2018.07.10' ,'W01' ,'SD0002' ,'MBBS' 
		EXECUTE DOCTOR_QUALIFICATION 'INSERT' , ' ' , ' ' ,'SLMC0003' , 'MR' , 'HARENDRA DE SILVA'      ,'PAEDIATRICIAN'      ,'VISITING' ,'COLOMBO' ,0715454234 ,224500 ,'2013.10.10' ,'W01' ,'SD0003' ,'MBBS'
		EXECUTE DOCTOR_QUALIFICATION 'INSERT' , ' ' , ' ' ,'SLMC0004' , 'MR' , 'SANJAYA ABEGUNAWARDHANA','PAEDIATRIC SURGEON' ,'RESIDENT' ,'COLOMBO' ,0718603434 ,260000 ,'2009.10.23' ,'W02' ,'SD0004' ,'MBBS'
		EXECUTE DOCTOR_QUALIFICATION 'INSERT' , ' ' , ' ' ,'SLMC0005' , 'MRS', 'WARUNA LIYANAGE'        ,'ORTHROPEDIC SURGEON','VISITING' ,'COLOMBO' ,0768603403 ,290000 ,'2010.11.10' ,'W03' ,'SD0005' ,'MBBS'
		
		
		INSERT INTO QUALIFICATION VALUES ('SD0001','MD'),('SD0001','DCH'),( 'SD0001','MRCP' )  
		INSERT INTO QUALIFICATION VALUES ('SD0002','MD'),('SD0002','DCH'),( 'SD0002','MRCP' )
		INSERT INTO QUALIFICATION VALUES ('SD0003','MD'),('SD0003','DCH'),( 'SD0003','MRCP' ),( 'SD0003','FRCP' )
		INSERT INTO QUALIFICATION VALUES ('SD0004','MD'),('SD0004','DCH'),( 'SD0004','MRCP' ),( 'SD0004','FRCP' )
		INSERT INTO QUALIFICATION VALUES ('SD0005','MD'),('SD0005','DCH'),( 'SD0005','MRCP' ),( 'SD0005','FRCP' ),( 'SD0005','MPHIL' )

		SELECT *
		FROM SPECIALIST_DOCTOR

		SELECT* 
		FROM QUALIFICATION

		SELECT*
		FROM SPECIALIST_DOCTOR, QUALIFICATION
		WHERE SPECIALIST_DOCTOR.Specialist_Doctor_Id = QUALIFICATION.Specialist_Doctor_Id

	--CREATE TABLE CHANNELING OFFICER

	--**********************************************
	--			Execute 7
	--**********************************************

	CREATE TABLE CHANNELING_OFFICER
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Channneling_Officer_Id AS 'C' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Officer_First_Name				VARCHAR (200)			NOT NULL,
		Officer_Middle_Name				VARCHAR (200)					,
		Officer_Last_Name				VARCHAR (200)			NOT NULL,
		Officer_Address			        VARCHAR (150)           NOT NULL,
		Officer_Tele_Number			    INT                     NOT NULL,
		Officer_DOB				        DATE                    NOT NULL,
		Officer_Salary					DECIMAL                 NOT NULL,
		Roll_Id							VARCHAR ( 8)					,

		CONSTRAINT pk_CHANNELING_OFFICER PRIMARY KEY ( Channneling_Officer_Id )                
	);

	--INSERT VALUES INTO THE CHANNELING OFFICER TABLE

	INSERT INTO CHANNELING_OFFICER VALUES ('SANJU',' NILUKSHAN',' DISSANAYAKA'    , 'COLOMBO'  , 0712123125, '1990.10.10', '45000.00', '')
	INSERT INTO CHANNELING_OFFICER VALUES ('RANGI',' PRIYADARSHANI',' RATHNAYAKA' , 'COLOMBO'  , 0771245456, '1998.09.25', '45000.00', '')
	INSERT INTO CHANNELING_OFFICER VALUES ('THUSHARI ','','DASANAYAKA'            , 'KALUTARA' , 0712123125, '1990.10.10', '45000.00', '')
	INSERT INTO CHANNELING_OFFICER VALUES ('SARANGA',' RANGANATH ','PEIRIS'       , 'MATARA'   , 0768989098, '1887.01.13', '45000.00', '')
	INSERT INTO CHANNELING_OFFICER VALUES ('NILANTHI',' DILRUKSHI ','RAMASINGHE'  , 'GALLE'    , 0717878654, '1970.09.12', '45000.00', '')

	SELECT*
	FROM CHANNELING_OFFICER

	 --CREATE TABLE BILLING OFFICER

	--**********************************************
	--			Execute 8
	--**********************************************

	CREATE TABLE BILLING_OFFICER
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Billing_Officer_Id AS 'B' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		B_Officer_First_Name			VARCHAR (200)			NOT NULL,
		B_Officer_Middle_Name			VARCHAR (200)					,
		B_Officer_Last_Name				VARCHAR (200)			NOT NULL,
		B_Officer_Address			    VARCHAR (150)           NOT NULL,
		B_Officer_Tele_Number			INT	                    NOT NULL,
		B_Officer_DOB				    DATE                    NOT NULL,
		B_Officer_Salary				DECIMAL                 NOT NULL,
		Roll_Id							VARCHAR ( 8)					,

		CONSTRAINT pk_BILLING_OFFICER PRIMARY KEY ( Billing_Officer_Id ),
		CONSTRAINT fk_BILLING_OFFICER FOREIGN KEY (Roll_id) REFERENCES ACCOUNT
		ON DELETE CASCADE          
	);

		--INSERT VALUES INTO BILLING OFFICER TABLE

		INSERT INTO BILLING_OFFICER VALUES ('SADUNI'  , 'MALSHA'    , 'DISANAYAKA '  , 'NO,29 KELANIYA'         , 0717878678, '1996.05.17', '54000.50', 'R0001')
		INSERT INTO BILLING_OFFICER VALUES ('MALEESHA', ' PRAMOD'   , ' DENIYEGEDARA', 'NO,30 GAMPAHA'          , 0772323123, '1994.10.22', '53000.00', 'R0002')
		INSERT INTO BILLING_OFFICER VALUES ('CHARITHA', ' PEIRIS'   , ' PEIRIS'      , 'NO 27/34 PANADURA'      , 0718989765, '1986.02.14', '51000.00', 'R0003')
		INSERT INTO BILLING_OFFICER VALUES ('HIRUNI'  , ' VIDUMINI' , ' PERERA'      , 'WEERAKETIYA RD TANGALLE', 0716565345, '1998.05.19', '44000.50', 'R0004')
		INSERT INTO BILLING_OFFICER VALUES ('HASINI'  , ' CHANCHALA', 'JAYAWARDHANA ', 'KATUBEDDA COLOMBO'      , 0772123123, '1990.03.17', '53500.50', 'R0005')
	
	SELECT * 
	FROM BILLING_OFFICER


	--CREATE TABLE BILL
	--**********************************************
	--			Execute 11
	--**********************************************

	CREATE TABLE BILL
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Bill_Number AS 'BILL' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Bill_Amount                     FLOAT                  NOT NULL,
		Payment_Date					DATE                   NOT NULL,
		Payment_Time                    TIME                   NOT NULL,
		Payment_Type					VARCHAR (20)           NOT NULL,
		Billing_Officer_Id              VARCHAR ( 8)		   NOT NULL,
		Guardian_Id_Number              VARCHAR ( 8)		   NOT NULL,

		CONSTRAINT pk_BILL PRIMARY KEY ( Bill_Number ),
		CONSTRAINT fk_BILL FOREIGN KEY ( Guardian_Id_Number ) REFERENCES GUARDIAN , 
						   FOREIGN KEY ( Billing_Officer_Id ) REFERENCES BILLING_OFFICER
						   ON DELETE CASCADE
						   
	);

	--INSERT VALUES INTO TABLE BILL

	INSERT INTO BILL VALUES('25000.00'  , SYSDATETIME(), SYSDATETIME(), 'CASH' , 'B0001','G0001') 
	INSERT INTO BILL VALUES('154000.00' , SYSDATETIME(), SYSDATETIME(), 'CASH' , 'B0001','G0002')
	INSERT INTO BILL VALUES('87300.00'  , SYSDATETIME(), SYSDATETIME(), 'CARD' , 'B0003','G0003')
	INSERT INTO BILL VALUES('99000.00'  , SYSDATETIME(), SYSDATETIME(), 'CASH' , 'B0002','G0004')
	INSERT INTO BILL VALUES('18750.00'  , SYSDATETIME(), SYSDATETIME(), 'CARD' , 'B0001','G0005')

	--CREATE TABLE ORGANIZATION

	--**********************************************
	--			Execute 12
	--**********************************************

	CREATE TABLE ORGANIZATION
	(
		Goverment_Reg_Number                 VARCHAR ( 20)                 NOT NULL UNIQUE,
		Organization_Name                    VARCHAR (150)                 NOT NULL,
		Organization_Address                 VARCHAR (150)				   NOT NULL,
		Bill_Number                          VARCHAR ( 11)                 NOT NULL,
		Billing_Officer_Id                   VARCHAR (  8)                 NOT NULL,

		CONSTRAINT pk_ORGANIZATION PRIMARY KEY ( Goverment_Reg_Number ) ,  
		CONSTRAINT fk_ORGANIZATION FOREIGN KEY ( Bill_Number) REFERENCES BILL , 
		                           FOREIGN KEY ( Billing_Officer_Id ) REFERENCES BILLING_OFFICER 
								   ON DELETE CASCADE
								   
	);

	--INSERT VALUES INTO ORGANIZATION TABLE 

	INSERT INTO ORGANIZATION VALUES ('GOV089654' , 'RDA'    , 'RDA MATARA'   , 'BILL0001' , 'B0001' )
	INSERT INTO ORGANIZATION VALUES ('GOV012444' , 'NIBM'   , 'NIBM COLOMBO' , 'BILL0002' , 'B0002' )
	INSERT INTO ORGANIZATION VALUES ('GOV009431' , 'SLT'    , 'SLT COLOMBO'  , 'BILL0003' , 'B0002' )
	INSERT INTO ORGANIZATION VALUES ('GOV097532' , 'MOBITEL', 'MOBITEL GALLE', 'BILL0004' , 'B0004' )



	--CREATE TABLE ADMISSION TABLE
	--**********************************************
	--			Execute 9
	--**********************************************

	CREATE TABLE ADMISSION_OFFICER
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Admission_Officer_Id AS 'A' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		A_Officer_First_Name			VARCHAR (200)			NOT NULL,
		A_Officer_Middle_Name			VARCHAR (200)					,
		A_Officer_Last_Name				VARCHAR (200)			NOT NULL,
		A_Officer_Address			    VARCHAR (150)           NOT NULL,
		A_Officer_Tele_Number			INT	                    NOT NULL,
		A_Officer_DOB				    DATE                    NOT NULL,
		A_Officer_Salary				DECIMAL                 NOT NULL,
		A_Job_Start_Date			    DATE                    NOT NULL,
		Roll_Id							VARCHAR ( 8)			NOT NULL,
	
		CONSTRAINT pk_ADMISSION_OFFICER PRIMARY KEY ( Admission_Officer_Id ),  
		CONSTRAINT fk_ADMISSION_OFFICER FOREIGN KEY ( Roll_Id ) REFERENCES ACCOUNT
		ON DELETE CASCADE
	);


		--INSERT VALUES INTO ADMISSION OFFICER TABLE

		INSERT INTO ADMISSION_OFFICER VALUES ('ACHIN'   , 'SUDHARAKA',' WIKRAMASINGHE' , 'NO,29 TANGALLE'     , 0717575643, '1996.06.19', '44000.50', '2017.10.02','R00011')
		INSERT INTO ADMISSION_OFFICER VALUES ('SACHINI' , 'SASHIKALA','PEIRIS'         , 'WELIGAMA RD MATARA' , 0778787545, '1995.02.16', '45000.50', '2017.10.02','R00012')
		INSERT INTO ADMISSION_OFFICER VALUES ('SANKA'   , 'DINELKA'  ,'GUNASEKARA'     , 'NO,17 PANADURA'     , 0768771231, '1986.01.29', '49000.50', '2017.10.02','R00013')
		INSERT INTO ADMISSION_OFFICER VALUES ('AYOMI'   , 'HARSHANI' ,'GUNADASA'       , 'KATUBEDDA MORATUWA' , 0713434787, '1989.05.19', '42000.00', '2017.10.02','R00014')
		INSERT INTO ADMISSION_OFFICER VALUES ('CHATHURA', 'MALITH'   ,'DASANAYAKA'     , 'NO,54 HOMAGAMA'     , 0760098090, '1998.08.21', '41000.50', '2017.10.02','R00015')

	--CREATE TABLE WARD STAFF

	CREATE TABLE WARD_STAFF
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Ward_Staff_Id AS 'W' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		W_Officer_First_Name			VARCHAR (200)			NOT NULL,
		W_Officer_Middle_Name			VARCHAR (200)					,
		W_Officer_Last_Name				VARCHAR (200)			NOT NULL,
		W_Officer_Address			    VARCHAR (150)           NOT NULL,
		W_Officer_Tele_Number			INT	                    NOT NULL,
		W_Officer_DOB				    DATE                    NOT NULL,
		W_Officer_Salary				DECIMAL                 NOT NULL,
		Designation						VARCHAR (30)			NOT NULL,
		W_Job_Start_Date			    DATE                    NOT NULL,
		Ward_Number						CHAR    (10)            NOT NULL,
		Roll_Id							VARCHAR ( 8)			        ,

		CONSTRAINT pk_WARD_STAFF PRIMARY KEY ( Ward_Staff_Id ),
		CONSTRAINT fk_WARD_STAFF FOREIGN KEY ( Ward_Number ) REFERENCES WARD,
	    FOREIGN KEY (Roll_id) REFERENCES ACCOUNT 
		ON DELETE CASCADE
	);

	--INSERT VALUES INTO WARD STAFF TABLE 

	INSERT INTO WARD_STAFF VALUES (' ACHIN'  ,' SUDHARAKA ',' WIKRAMASINGHE', 'NO,29 TANGALLE'     , 0717575643, '1996.06.19', '44000.50', 'NURSE'  ,'2017.10.02', 'W01','R00016')
	INSERT INTO WARD_STAFF VALUES (' SACHINI','  SASHIKALA','  PEIRIS'      , 'WELIGAMA RD MATARA' , 0778787545, '1995.02.16', '45000.50', 'NURSE'  ,'2017.10.02', 'W02','R00017')


	SELECT*
	FROM WARD_STAFF,ACCOUNT
	WHERE WARD_STAFF.Roll_id = ACCOUNT.Roll_id

	--CREATE TABLE GUARDIAN

	--**********************************************
	--			Execute 10
	--**********************************************

	CREATE TABLE GUARDIAN
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Guardian_Id_Number AS 'G' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Guardian_NIC                    CHAR    (10)            NOT NULL UNIQUE,
		Guardian_Name					VARCHAR (90)            NOT NULL,
		Guardian_Address				VARCHAR (150)			NOT NULL,
		Gurdian_Tele_No					INT                     NOT NULL,
		Relationship					VARCHAR (50)			NOT NULL,
		Admission_Officer_Id 			VARCHAR ( 8)			NOT NULL,
		Billing_Officer_Id				VARCHAR ( 8)                    ,

		CONSTRAINT pk_GUARDIAN PRIMARY KEY ( Guardian_Id_Number ),
		CONSTRAINT fk_GUARDIAN FOREIGN KEY ( Admission_Officer_Id ) REFERENCES ADMISSION_OFFICER,
		FOREIGN KEY (Billing_Officer_Id) REFERENCES BILLING_OFFICER
		ON DELETE CASCADE						  
							    
	);

	SELECT*
	FROM GUARDIAN

	--CREATE TABLE PATIENT PRIVATE DETAILS (ALL PATIENTS)

	--**********************************************
	--			Execute 13
	--**********************************************

	CREATE TABLE PATIENT_PRIVATE_DETAIL
	(
		Patient_Id_Number				INT		IDENTITY (1,1)	NOT NULL, 
		Patient_First_Name				VARCHAR (200)			NOT NULL,
		Patient_Middle_Name				VARCHAR (200)			        ,
		Patient_Last_Name				VARCHAR (200)			NOT NULL,
		Gender							VARCHAR (10)			NOT NULL,
		Date_Of_Birth					DATE					NOT NULL,
		Age								INT						NOT NULL,
		Blood_Group						CHAR    (50)			NOT NULL,
		Guardian_Id_Number				VARCHAR ( 8)            NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,

		CONSTRAINT pk_PATIENT_PRIVATE_DETAIL PRIMARY KEY ( Patient_Id_Number ),
		CONSTRAINT fk_PATIENT_PRIVATE_DETAIL FOREIGN KEY ( Guardian_Id_Number ) REFERENCES GUARDIAN,
											 FOREIGN KEY ( Specialist_Doctor_Id ) REFERENCES SPECIALIST_DOCTOR
											 ON DELETE CASCADE										 
	);

	--INSERT VALUES INTO GUARDIAN AND PATIENT PRIVATE DETAILS USING A STORED PROCEDURE

	CREATE PROCEDURE PATIENT_PRIVATE_DETAIL_GUARDIAN
	(
		@Action							VARCHAR(30),
		@Number							INT		     ,
		@Num                            INT ,
		@Guardian_Id_Number				VARCHAR ( 8) ,
		@Guardian_NIC                   CHAR    (12) ,
		@Guardian_Name					VARCHAR (90) ,
		@Guardian_Address				VARCHAR (150),
		@Gurdian_Tele_No				INT          ,
		@Relationship					VARCHAR (50) ,
		@Admission_Officer_Id 			VARCHAR ( 8) ,
		@Billing_Officer_Id             VARCHAR ( 8) ,
		@Patient_Id_Number				INT		     , 
		@Patient_First_Name				VARCHAR (200),
		@Patient_Middle_Name			VARCHAR (200),
		@Patient_Last_Name				VARCHAR (200),
		@Gender							VARCHAR (10) ,
		@Date_Of_Birth					DATE		 ,
		@Age							INT			 ,
		@Blood_Group					CHAR    (50) ,
		@G_id                           VARCHAR ( 8) ,
		@Specialist_Doctor_Id			VARCHAR ( 9)					
		)
		AS

		IF @ACTION = 'INSERT'
		BEGIN
		INSERT INTO GUARDIAN
		SELECT @Guardian_NIC,@Guardian_Name,@Guardian_Address,@Gurdian_Tele_No,@Relationship,
		@Admission_Officer_Id,@Billing_Officer_Id

		INSERT INTO  PATIENT_PRIVATE_DETAIL
		SELECT @Patient_First_Name,@Patient_Middle_Name,@Patient_Last_Name,@Gender,@Date_Of_Birth,@Age,@Blood_Group,@G_id ,@Specialist_Doctor_Id

		END
		GO

		EXECUTE PATIENT_PRIVATE_DETAIL_GUARDIAN 'INSERT','','','','722283359V','SAMAN LAKMAL'      ,'COLOMBO' ,0712323567,'FATHER','A0001','B0001 ','','BIHANDU', 'NETHSARA', 'DISANAYAKA' ,'MALE'  ,'2015.10.10',5,'A+','G0001','SD0001'
		EXECUTE PATIENT_PRIVATE_DETAIL_GUARDIAN 'INSERT','','','','743467875V','SHALIKA RATHNAYAKA','COLOMBO' ,0776734215,'MOTHER','A0002','B0002', '','SANDUNI', 'MIHINADI', 'PEIRIS'     ,'FEMALE','2018.02.13',2,'B+','G0002','SD0001'
		EXECUTE PATIENT_PRIVATE_DETAIL_GUARDIAN 'INSERT','','','','798767542V','SURANGA SATHSARA'  ,'PANADURA',0704523451,'FATHER','A0003','B0003', '','ASHWINI', 'BIMENDA' , 'SENARATH'    ,'FEMALE','2017.11.25',3,'A+','G0003','SD0004'
		EXECUTE PATIENT_PRIVATE_DETAIL_GUARDIAN 'INSERT','','','','822283359V','SHASIKA HARSHANI'  ,'HOMAGAMA',0712323864,'MOTHER','A0004','B0004', '','MALISHA', 'PRAMOD'  , 'JAYATHILAKA'  ,'MALE'  ,'2013.09.30',7,'B+','G0004','SD0002'
		EXECUTE PATIENT_PRIVATE_DETAIL_GUARDIAN 'INSERT','','','','892283359V','PAWANI SANJANA'    ,'COLOMBO' ,0708754321,'MOTHER','A0005','B0005', '','SITHUM' , 'SATHSARA', 'PERERA'      ,'MALE'  ,'2019.10.20',1,'A+','G0005','SD0001'
		
		SELECT*
		FROM PATIENT_PRIVATE_DETAIL,GUARDIAN
		WHERE PATIENT_PRIVATE_DETAIL.Guardian_Id_Number=GUARDIAN.Guardian_Id_Number

	--CREATE TABLE CUSTOMER 

	--**********************************************
	--			Execute 14
	--**********************************************

	CREATE TABLE CUSTOMER
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Invoice_Number	 AS 'I' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,
		
		Appointment_Number				INT         			NOT NULL,
		Consultant_Name                 VARCHAR (50)			NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,
		Session_Date                    VARCHAR (10)			NOT NULL,
		Patient_Name					VARCHAR (90)			NOT NULL,
		Contact_Number			        INT                     NOT NULL,
		Hospital_Fee					INT                     NOT NULL,
		Doctor_Fee						INT                     NOT NULL,	
		Issue_Time						TIME                    NOT NULL,
		Issue_Date						DATE                    NOT NULL,
		Channneling_Officer_Id 			VARCHAR  (8)			NOT NULL,

		CONSTRAINT pk_CUSTOMER PRIMARY KEY ( Invoice_Number ),
		CONSTRAINT fk_CUSTOMER FOREIGN KEY ( Channneling_Officer_Id ) REFERENCES CHANNELING_OFFICER,
		FOREIGN KEY (Specialist_Doctor_Id) REFERENCES SPECIALIST_DOCTOR
		ON DELETE CASCADE
	);

	--INSERT VALUES INTO CUSTOMER TABLE 

	INSERT INTO CUSTOMER VALUES(0001, 'DILRUKSHI RUBERU'   , 'SD0001', '2020.10.10', 'SANJU NILUKSHAN'    , 0786767543,1000,500, SYSDATETIME(), SYSDATETIME(), 'C0001')
	INSERT INTO CUSTOMER VALUES(0002, 'DILRUKSHI RUBERU'   , 'SD0001', '2020.10.11', 'BIHANDU NETHSARA'   , 0712345678,1000,500, SYSDATETIME(), SYSDATETIME(), 'C0002')
	INSERT INTO CUSTOMER VALUES(0003, 'KOSALA KARUNARATHNA', 'SD0002', '2020.10.08', 'NILANTHI RAMASINGHE', 0701256432,1500,500, SYSDATETIME(), SYSDATETIME(), 'C0003')
	
	--CREATE TABLE FOR PATINET APPOINTMENT DETAILS

	--**********************************************
	--			Execute 15
	--**********************************************

	CREATE TABLE PATIENT_APPOINTMENT_DETAILS
	(
		Patient_Id_Number				INT						NOT NULL, 
		Invoice_Number					VARCHAR  (8)            NOT NULL,

		CONSTRAINT pk_PATIENT_APPOINTMENT_DETAILS PRIMARY KEY ( Patient_Id_Number, Invoice_Number ),
		CONSTRAINT fk_PATIENT_APPOINTMENT_DETAILS FOREIGN KEY ( Patient_Id_Number ) REFERENCES PATIENT_PRIVATE_DETAIL ,
												  FOREIGN KEY ( Invoice_Number ) REFERENCES CUSTOMER
												  ON DELETE CASCADE
												  
	);

	--INSERT VALUES INTO PATIENT APPOINTMENT DETAIL TABLE

	INSERT INTO PATIENT_APPOINTMENT_DETAILS VALUES (1,'I0001')
	INSERT INTO PATIENT_APPOINTMENT_DETAILS VALUES (2,'I0002')
	INSERT INTO PATIENT_APPOINTMENT_DETAILS VALUES (3,'I0003')

	SELECT *
	FROM  PATIENT_APPOINTMENT_DETAILS


	--CREATE TABLE IN PATIENT 

	--**********************************************
	--			Execute 16
	--**********************************************

	CREATE TABLE IN_PATIENT
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Admission_Number AS 'AD' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,	

		Patient_Id_Number				INT						NOT NULL, 
		Reason							VARCHAR (200)           NOT NULL,
		Admit_Time						TIME                            ,
		Admit_Date						DATE							,	
		Discharge_Time					TIME                            ,
		Discharge_Date					DATE							,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,
		Ward_Number						CHAR    (10)            NOT NULL ,					
		Room_Number						CHAR    (10)            NOT NULL,

		CONSTRAINT pk_IN_PATIENT PRIMARY KEY ( Admission_Number ),
		CONSTRAINT fk_IN_PATIENT FOREIGN KEY ( Specialist_Doctor_Id ) REFERENCES SPECIALIST_DOCTOR,
								 FOREIGN KEY ( Ward_Number ) REFERENCES WARD,
								 FOREIGN KEY ( Room_Number ) REFERENCES ROOM,
								 FOREIGN KEY ( Patient_Id_Number ) REFERENCES PATIENT_PRIVATE_DETAIL
								 ON DELETE CASCADE
								 
	);


	--INSERT VALUES INTO INPATIENT TABLE

	INSERT INTO IN_PATIENT VALUES (1, 'FEVER'      , SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), 'SD0001','W01', 'R001')
	INSERT INTO IN_PATIENT VALUES (2, 'INFLUENZA A', SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), 'SD0001','W01', 'R002')
	INSERT INTO IN_PATIENT VALUES (3, 'DIABETES'   , SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), 'SD0002','W02', 'R003')
	INSERT INTO IN_PATIENT VALUES (4, 'FEVER'      , SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), 'SD0001','W03', 'R004')
	INSERT INTO IN_PATIENT VALUES (5, 'COMMON COLD', SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), SYSDATETIME(), 'SD0002','W01', 'R001')
	
	SELECT * FROM IN_PATIENT

	--CREATE TABLE OUT PATIENT

	--**********************************************
	--			Execute 17
	--**********************************************

	CREATE TABLE OUT_PATIENT
	(
		Out_Patient_Id_Number			INT	IDENTITY  (1,1)		NOT NULL,
		Patient_Name					VARCHAR       (70 )		NOT NULL,
		Guardian_NIC                    VARCHAR       (12 )     NOT NULL,
		Guardian_Tele_No                INT                     NOT NULL,
		Age								INT						NOT NULL,
		Reason							VARCHAR       (200)     NOT NULL, 
		C_Date							DATE					NOT NULL,
		C_Time							TIME					NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,
		
		CONSTRAINT pk_OUT_PATIENT PRIMARY KEY (	Out_Patient_Id_Number )	,	
		CONSTRAINT fk_OUT_PATIENT FOREIGN KEY ( Specialist_Doctor_Id ) REFERENCES SPECIALIST_DOCTOR
	);

	

	--INSERT VALUES INTO OUT PATIENT TABLE

	INSERT INTO OUT_PATIENT VALUES ('BIHANDU NETHSARA', '786556787V', 0714534543 , 10 , 'FEVER' , SYSDATETIME(), SYSDATETIME() ,'SD0001')
	INSERT INTO OUT_PATIENT VALUES ('CHANDU SINETH'   , '876554328V', 0778965439 , 16 , 'FEVER' , SYSDATETIME(), SYSDATETIME() ,'SD0001')
	INSERT INTO OUT_PATIENT VALUES ('OSHADA NISITH'   , '906554324V', 0708745446 , 05 , 'COUGH' , SYSDATETIME(), SYSDATETIME() ,'SD0001')
	INSERT INTO OUT_PATIENT VALUES ('NISHARA SANSIDI' , '776534689V', 0714742090 , 03 , 'FEVER' , SYSDATETIME(), SYSDATETIME() ,'SD0001')
	INSERT INTO OUT_PATIENT VALUES ('ANUPA YAHAS'     , '790654767V', 0701256321 , 07 , 'FEVER' , SYSDATETIME(), SYSDATETIME() ,'SD0001')
	
	SELECT * FROM OUT_PATIENT;

	--CREATE TABLE PHARMACY STAFF

	--**********************************************
	--			Execute 18
	--**********************************************

	CREATE TABLE PHARMACY_STAFF
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Pharmacy_Staff_Id AS 'P' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		P_Officer_First_Name			VARCHAR (200)			NOT NULL,
		P_Officer_Middle_Name			VARCHAR (200)					,
		P_Officer_Last_Name				VARCHAR (200)			NOT NULL,
		P_Officer_Address			    VARCHAR (150)           NOT NULL,
		P_Officer_Tele_Number			INT	                    NOT NULL,
		P_Officer_DOB				    DATE                    NOT NULL,
		P_Officer_Salary				DECIMAL                 NOT NULL,
		Designation						VARCHAR (30)			NOT NULL,
		P_Job_Start_Date			    DATE                    NOT NULL,
		Roll_Id							VARCHAR ( 8)			        ,

	    CONSTRAINT pk_PHARMACY_STAFF PRIMARY KEY ( Pharmacy_Staff_Id ),              
		CONSTRAINT fk_PHARMACY_STAFF FOREIGN KEY (Roll_id) REFERENCES ACCOUNT 
		ON DELETE CASCADE
	);

	--INSERT VALUES INTO PHARMACY STAFF TABLE 
	
	INSERT INTO PHARMACY_STAFF VALUES ('SANKA'   ,' DINELKA'  ,' GUNASEKARA'  , 'NO,17 PANADURA'     , 0768771231, '1986.01.29', '49000.50', 'PHARMACIAN' ,'2017.10.02','R00018')
	INSERT INTO PHARMACY_STAFF VALUES ('AYOMI'   ,' HARSHANI' ,' GUNADASA'    , 'KATUBEDDA MORATUWA' , 0713434787, '1989.05.19', '42000.00', 'PHARMACIAN' ,'2017.10.02','R00019')
	INSERT INTO PHARMACY_STAFF VALUES ('CHATHURA',' MALITH '  ,'DASANAYAKA'   , 'NO,54 HOMAGAMA'     , 0760098090, '1998.08.21', '41000.50', 'PHARMACIAN' ,'2017.10.02','R00020')

	
	--CREATE TABLE DRUG

	--**********************************************
	--			Execute 19
	--**********************************************

	CREATE TABLE DRUG
	(
	    Number							INT		IDENTITY (1,1)  NOT NULL, 

		Drug_Code AS 'DRUG' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Drug_Name                       VARCHAR (30)             NOT NULL,
		Trade_Number                    VARCHAR (10)             NOT NULL,
		Store_Place                     VARCHAR (30)             NOT NULL,
		Drug_Price                      FLOAT                    NOT NULL,
        
		CONSTRAINT pk_DRUG PRIMARY KEY ( Drug_Code )	
	);


	--INSERT VALUES INTO DRUG TABLE

	INSERT INTO DRUG VALUES ('ASTIFEN'   , 'TRADE9876' , 'REFG6767' , '1000'  )
	INSERT INTO DRUG VALUES ('ATALINE'   , 'TRADE0096' , 'REFG6760' , '1200'  )
	INSERT INTO DRUG VALUES ('MONAKA'    , 'TRADE2345' , 'REFG6761' , '700'   )
	INSERT INTO DRUG VALUES ('AUGMENTIN' , 'TRADE7878' , 'REFG6767' , '12000' )
	INSERT INTO DRUG VALUES ('PANADOL'   , 'TRADE0001' , 'REFG6767' , '450'   ) 


	--CREATE TABLE DRUG SUPPLIER

	--**********************************************
	--			Execute 20
	--**********************************************

	CREATE TABLE DRUG_SUPPLIER
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Supplier_Id AS 'S' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,
		Supplier_Name					VARCHAR ( 90)            NOT NULL,
		Manufacture_Company				VARCHAR (100)			 NOT NULL,
		Manufacture_Country				VARCHAR ( 20)            NOT NULL,
		Manufacture_Reg_Number			VARCHAR ( 30)			 NOT NULL,

		CONSTRAINT pk_DRUG_SUPPLIER PRIMARY KEY ( Supplier_Id ) 
	);

	--INSERT VALUES INTO DRUG SUPPLIER TABLE

	INSERT INTO DRUG_SUPPLIER VALUES ('RHA COMPANY'   , 'HOKO MEDICINE', 'AMERICA'   , 'REG12122')
	INSERT INTO DRUG_SUPPLIER VALUES ('NILKA PVT LMT' , 'HYTE MED CARE', 'AUSTRALIA' , 'REG09877')

	--CREATE TABLE DRUG ORDER

	--**********************************************
	--			Execute 21
	--**********************************************

	CREATE TABLE DRUG_ORDER
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Order_Number AS 'O' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Drug_Code                       VARCHAR (11)		     NOT NULL,
		Drug_Name						VARCHAR (30)             NOT NULL,
		Quantity						INT						 NOT NULL,
		Order_Date						DATE					 NOT NULL,	
		Supplier_Id						VARCHAR (  8)            NOT NULL,
		Supply_Date						DATE					 NOT NULL,
		Supply_Time						TIME					 NOT NULL,
		Supply_Quantity					INT						 NOT NULL,
		Manufacture_Date				DATE					 NOT NULL,
		Expire_Date                     DATE					 NOT NULL,
		Total_Bill_Amount				FLOAT					 NOT NULL,
		Pharmacy_Staff_Id				VARCHAR ( 8)		     NOT NULL,

		CONSTRAINT pk_DRUG_ORDER PRIMARY KEY ( Order_Number),
		CONSTRAINT fk_DRUG_ORDER  FOREIGN KEY ( Drug_Code ) REFERENCES DRUG,
		                         FOREIGN KEY ( Supplier_Id ) REFERENCES DRUG_SUPPLIER
								 ON DELETE CASCADE
								 
	);


	--INSERT VALUES INTO TABLE DRUG ORDER

	INSERT INTO DRUG_ORDER VALUES ('DRUG0001', 'ASTIFEN', 1000, SYSDATETIME(),'S0001', ' ', ' ', 2000, '2019.10.10', '2021.10.10' ,'120000.00', 'P0001')

	SELECT * 
	FROM DRUG_ORDER;


	--CREATE TABLE HOSPITAL CUSTOMER (Customers who takes medicines from pharmacy)

	--**********************************************
	--			Execute 22
	--**********************************************

	CREATE TABLE HOSPITAL_CUSTOMER
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Pharmacy_Invoice_Number AS 'PI' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,
		
		Patient_Id_Number				INT					    NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,
		Total_Bill					    DECIMAL					NOT NULL,
		Issue_Date						DATE					NOT NULL,
		Issue_Time						TIME					NOT NULL,
		Pharmacy_Staff_Id				VARCHAR ( 8)		     NOT NULL, 

		CONSTRAINT pk_HOSPITAL_CUSTOMER PRIMARY KEY ( Pharmacy_Invoice_Number ),
		CONSTRAINT fk_HOSPITAL_CUSTOMER FOREIGN KEY ( Patient_Id_Number )     REFERENCES PATIENT_PRIVATE_DETAIL,
		                                FOREIGN KEY ( Specialist_Doctor_Id )  REFERENCES SPECIALIST_DOCTOR ,
										FOREIGN KEY ( Pharmacy_Staff_Id )     REFERENCES PHARMACY_STAFF
										ON DELETE CASCADE
										
	);

	SELECT * 
	FROM HOSPITAL_CUSTOMER;

	--CREATE TABLE PHARMACY MEDICINES ( Medicines taken by pharmacy customer)

	--**********************************************
	--			Execute 23
	--**********************************************

	CREATE TABLE PHARMACY_MEDICINES
	(
		Pharmacy_Invoice_Number			VARCHAR ( 9)			NOT NULL,
		Drug_Code                       VARCHAR (11)		     NOT NULL,
		Quantity						INT						NOT NULL,
		Number_Of_Days					INT						NOT NULL,

		CONSTRAINT pk_PHARMACY_MEDICINES PRIMARY KEY ( Pharmacy_Invoice_Number , Drug_Code ),
		CONSTRAINT fk_PHARMACY_MEDICINES FOREIGN KEY ( Pharmacy_Invoice_Number ) REFERENCES HOSPITAL_CUSTOMER,
		                                 FOREIGN KEY ( Drug_Code  )  REFERENCES DRUG
										 ON DELETE CASCADE
										 
	);

	SELECT * 
	FROM PHARMACY_MEDICINES;

	--INSERT VALUS INTP HOSPITAL CUSTOMER AND PHARMACY MEDICINES TABLES USING STORED PROCEDURE

	CREATE PROCEDURE HOSPITAL_CUSTOMER_PHARMACY_MEDICINES
	(
		@Action                         VARCHAR (8) ,
		@Number							INT			, 
		@Pharmacy_Invoice_Number		VARCHAR	(9)	,	
		@Patient_Id_Number				INT			,
		@Specialist_Doctor_Id			VARCHAR (9) ,
		@Total_Bill					    DECIMAL		,
		@Issue_Date						DATE		,
		@Issue_Time						TIME		,
		@Pharmacy_Staff_Id				VARCHAR (8) ,
		@Pharmacy_Invoice_Num  		    VARCHAR	(9)	,	
		@Drug_Code						VARCHAR (11),
		@Quantity						INT			,
		@Number_Of_Days					INT			
	)

	AS
	IF @Action= 'INSERT'
	BEGIN
	INSERT INTO HOSPITAL_CUSTOMER
	SELECT @Patient_Id_Number,@Specialist_Doctor_Id,@Total_Bill,@Issue_Date,@Issue_Time,@Pharmacy_Staff_Id

	INSERT INTO PHARMACY_MEDICINES
	SELECT @Pharmacy_Invoice_Num,@Drug_Code,@Quantity,@Number_Of_Days	

	END 
	GO

    EXECUTE HOSPITAL_CUSTOMER_PHARMACY_MEDICINES 'INSERT' , ' ', ' ', 1 , 'SD0001' , '2000.00', ' ', ' ' , 'P0002' ,'PI0001' ,'DRUG0001' , 10 , 5
	EXECUTE HOSPITAL_CUSTOMER_PHARMACY_MEDICINES 'INSERT' , ' ', ' ', 2 , 'SD0001' , '5000.00', ' ', ' ' , 'P0001' ,'PI0002' ,'DRUG0002' , 10 , 5
	EXECUTE HOSPITAL_CUSTOMER_PHARMACY_MEDICINES 'INSERT' , ' ', ' ', 3 , 'SD0001' , '6500.00', ' ', ' ' , 'P0001' ,'PI0003' ,'DRUG0003' , 10 , 5
	EXECUTE HOSPITAL_CUSTOMER_PHARMACY_MEDICINES 'INSERT' , ' ', ' ', 4 , 'SD0001' , '8700.00', ' ', ' ' , 'P0003' ,'PI0004' ,'DRUG0004' , 10 , 5
	EXECUTE HOSPITAL_CUSTOMER_PHARMACY_MEDICINES 'INSERT' , ' ', ' ', 5 , 'SD0001' , '9000.00', ' ', ' ' , 'P0001' ,'PI0005' ,'DRUG0001' , 10 , 5

	INSERT INTO PHARMACY_MEDICINES VALUES ('PI0001','DRUG0002', 2, 5)
	INSERT INTO PHARMACY_MEDICINES VALUES ('PI0001','DRUG0003', 7, 4)

	SELECT*
	FROM HOSPITAL_CUSTOMER,PHARMACY_MEDICINES
	WHERE HOSPITAL_CUSTOMER.Pharmacy_Invoice_Number=PHARMACY_MEDICINES.Pharmacy_Invoice_Number


	--CREATE TABLE N PATIENT MEDICINE

	--**********************************************
	--			Execute 24
	--**********************************************

	CREATE TABLE IN_PATIENT_MEDICINE
	(
		Admission_Number				VARCHAR ( 9)			NOT NULL,
		Drug_Code                       VARCHAR (11)		    NOT NULL,
		Quantity						VARCHAR (10)            NOT NULL,
		Given_Time						TIME					NOT NULL,
		Given_Date						DATE					NOT NULL,

		CONSTRAINT pk_IN_PATIENT_MEDICINE PRIMARY KEY ( Admission_Number, Drug_Code ),
		CONSTRAINT fk_IN_PATIENT_MEDICINE FOREIGN KEY ( Admission_Number ) REFERENCES  IN_PATIENT,
										  FOREIGN KEY ( Drug_Code ) REFERENCES DRUG
										  ON DELETE CASCADE
										  
	);

	--INSERT VALUES INTO IN PATIENT MEDICINE TABLE 

	INSERT INTO IN_PATIENT_MEDICINE VALUES ('AD0001' , 'DRUG0001' , 10, SYSDATETIME(), SYSDATETIME() )
	INSERT INTO IN_PATIENT_MEDICINE VALUES ('AD0001' , 'DRUG0002' , 07, SYSDATETIME(), SYSDATETIME() )
	INSERT INTO IN_PATIENT_MEDICINE VALUES ('AD0002' , 'DRUG0001' , 18, SYSDATETIME(), SYSDATETIME() )
	INSERT INTO IN_PATIENT_MEDICINE VALUES ('AD0002' , 'DRUG0002' , 02, SYSDATETIME(), SYSDATETIME() )
	INSERT INTO IN_PATIENT_MEDICINE VALUES ('AD0002' , 'DRUG0004' , 08, SYSDATETIME(), SYSDATETIME() )

	--CREATE TABLE OUT PATIENT MEDICINE

	--**********************************************
	--			Execute 25
	--**********************************************

	CREATE TABLE OUT_PATIENT_MEDICINE
	(
		Out_Patient_Id_Number			INT						NOT NULL,
		Drug_Code                       VARCHAR (11)		    NOT NULL,
		Quantity			            VARCHAR (10)            NOT NULL,			
		Number_Of_Day					INT						NOT NULL,
		Issue_Date						DATE                    NOT NULL,

		CONSTRAINT pk_OUT_PATIENT_MEDICINE PRIMARY KEY ( Out_Patient_Id_Number , Drug_Code ),
		CONSTRAINT fk_OUT_PATIENT_MEDICINE FOREIGN KEY ( Out_Patient_Id_Number ) REFERENCES OUT_PATIENT,
										   FOREIGN KEY ( Drug_Code ) REFERENCES DRUG 
										   ON DELETE CASCADE									   
	);

	--INSERT VALUES INTO OUT PATIENT MEDICINE TABLE

	INSERT INTO OUT_PATIENT_MEDICINE VALUES (1, 'DRUG0001', 10 , 5, SYSDATETIME() )
	INSERT INTO OUT_PATIENT_MEDICINE VALUES (1, 'DRUG0002', 10 , 4, SYSDATETIME() )
	INSERT INTO OUT_PATIENT_MEDICINE VALUES (1, 'DRUG0003', 10 , 5, SYSDATETIME() )
	INSERT INTO OUT_PATIENT_MEDICINE VALUES (1, 'DRUG0004', 10 , 3, SYSDATETIME() )
	INSERT INTO OUT_PATIENT_MEDICINE VALUES (2, 'DRUG0001', 10 , 5, SYSDATETIME() )
	INSERT INTO OUT_PATIENT_MEDICINE VALUES (2, 'DRUG0002', 10 , 4, SYSDATETIME() )
	INSERT INTO OUT_PATIENT_MEDICINE VALUES (2, 'DRUG0003', 10 , 5, SYSDATETIME() )
	INSERT INTO OUT_PATIENT_MEDICINE VALUES (2, 'DRUG0004', 10 , 3, SYSDATETIME() )
	 

	--CREATE TABLE FOR LABORATORY STAFF

	--**********************************************
	--			Execute 26
	--**********************************************

	CREATE TABLE LABORATORY_STAFF
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Laboratory_Staff_Id AS 'L' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		L_Officer_First_Name			VARCHAR (200)			NOT NULL,
		L_Officer_Middle_Name			VARCHAR (200)					,
		L_Officer_Last_Name				VARCHAR (200)			NOT NULL,
		L_Officer_Address			    VARCHAR (150)           NOT NULL,
		L_Officer_Tele_Number			INT	                    NOT NULL,
		L_Officer_DOB				    DATE                    NOT NULL,
		L_Officer_Salary				DECIMAL                 NOT NULL,
		Designation						VARCHAR (30)			NOT NULL,
		L_Job_Start_Date			    DATE                    NOT NULL,
	
		CONSTRAINT pk_LABORATORY_STAFF PRIMARY KEY ( Laboratory_Staff_Id )              
	);

	--INSERT VALUES INTO LABORATORY STAFF TABLE 

	INSERT INTO LABORATORY_STAFF VALUES ('ACHIN'   ,'SUDHARAKA' ,'WIKRAMASINGHE', 'NO,29 TANGALLE'     , 0717575643, '1996.06.19', '44000.50', 'LABORATORIAN'           ,'2017.10.02')
	INSERT INTO LABORATORY_STAFF VALUES ('SACHINI' ,'SASHIKALA' ,'PEIRIS'       , 'WELIGAMA RD MATARA' , 0778787545, '1995.02.16', '45000.50', 'LABORATORIAN'           ,'2017.10.02')
	INSERT INTO LABORATORY_STAFF VALUES ('SANKA'   ,'DINELKA '  ,'GUNASEKARA'   , 'NO,17 PANADURA'     , 0768771231, '1986.01.29', '49000.50', 'ASSISTANT LABORATORIAN' ,'2017.10.02')
	INSERT INTO LABORATORY_STAFF VALUES ('AYOMI'   ,'HARSHANI'  ,'GUNADASA'     , 'KATUBEDDA MORATUWA' , 0713434787, '1989.05.19', '42000.00', 'LABORATORIAN'           ,'2017.10.02')
	INSERT INTO LABORATORY_STAFF VALUES ('CHATHURA','MALITH'    ,'DASANAYAKA'   , 'NO,54 HOMAGAMA'     , 0760098090, '1998.08.21', '41000.50', 'ASSISTANT LABORATORIAN' ,'2017.10.02')

	--CREATE TABLE IN PATIENT LABORATORY SAMPLES

	--**********************************************
	--			Execute 27
	--**********************************************

	CREATE TABLE IN_SAMPLE
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Sample_In_Number AS 'SI' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Patient_Id_Number				INT						NOT NULL,	
		Sample_Type						VARCHAR (10)			NOT NULL,
		Ward_Number						CHAR    (10)            NOT NULL,
		Room_Number						CHAR    (10)            NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,
		Laboratory_Staff_Id             VARCHAR ( 8)			NOT NULL,
		Received_Date					DATE					NOT NULL,
		Received_Time					TIME					NOT NULL,

		CONSTRAINT pk_IN_SAMPLE PRIMARY KEY ( Sample_In_Number ),
		CONSTRAINT fk_IN_SAMPLE FOREIGN KEY ( Patient_Id_Number )     REFERENCES PATIENT_PRIVATE_DETAIL,
		                        FOREIGN KEY ( Specialist_Doctor_Id )  REFERENCES SPECIALIST_DOCTOR
								ON DELETE CASCADE
								
	);

	--INSERT VALUES INTO IN SAMPLE TABLE

	INSERT INTO IN_SAMPLE VALUES (1, 'BLOOD', 'W01', 'R001', 'SD0001', 'L0001', SYSDATETIME(), SYSDATETIME())
	INSERT INTO IN_SAMPLE VALUES (2, 'BLOOD', 'W01', 'R002', 'SD0001', 'L0002', SYSDATETIME(), SYSDATETIME())
	INSERT INTO IN_SAMPLE VALUES (3, 'URINE', 'W02', 'R003', 'SD0002', 'L0002', SYSDATETIME(), SYSDATETIME())
	INSERT INTO IN_SAMPLE VALUES (4, 'BLOOD', 'W01', 'R001', 'SD0001', 'L0004', SYSDATETIME(), SYSDATETIME())
	INSERT INTO IN_SAMPLE VALUES (5, 'URINE', 'W05', 'R006', 'SD0004', 'L0003', SYSDATETIME(), SYSDATETIME())

	--CREATE TABLE FOR LABORATORY OUT PATIENT SAMPLE

	--**********************************************
	--			Execute 28
	--**********************************************

	CREATE TABLE OUT_SAMPLE
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Sample_Out_Number AS 'SO' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Patient_Id_Number				INT						NOT NULL,	
		Sample_Type						VARCHAR (10)			NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,
		Laboratory_Staff_Id             VARCHAR ( 8)			NOT NULL,
		Received_Date					DATE					NOT NULL,
		Received_Time					TIME					NOT NULL,

		CONSTRAINT pk_OUT_SAMPLE PRIMARY KEY ( Sample_Out_Number ),
		CONSTRAINT fk_OUT_SAMPLE FOREIGN KEY ( Patient_Id_Number )     REFERENCES PATIENT_PRIVATE_DETAIL,
		                         FOREIGN KEY ( Specialist_Doctor_Id )  REFERENCES SPECIALIST_DOCTOR 
								 ON DELETE CASCADE
								 
	); 

	--INSERT VALUES INTO OUT PATIENT SAMPLE TABLE

	INSERT INTO OUT_SAMPLE VALUES (1, 'BLOOD',  'SD0001', 'L0001', SYSDATETIME(), SYSDATETIME())
	INSERT INTO OUT_SAMPLE VALUES (2, 'BLOOD',  'SD0001', 'L0002', SYSDATETIME(), SYSDATETIME())
	INSERT INTO OUT_SAMPLE VALUES (3, 'URINE',  'SD0002', 'L0002', SYSDATETIME(), SYSDATETIME())
	INSERT INTO OUT_SAMPLE VALUES (4, 'BLOOD',  'SD0001', 'L0004', SYSDATETIME(), SYSDATETIME())
	INSERT INTO OUT_SAMPLE VALUES (5, 'URINE',  'SD0004', 'L0003', SYSDATETIME(), SYSDATETIME())


	--**********************************************
	--			Execute 29
	--**********************************************

	CREATE TABLE IN_PATIENT_REPORT
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		In_Patient_Report_No AS 'IR' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Admission_Number				VARCHAR   ( 9)			NOT NULL,
		Report                          IMAGE                   NOT NULL,
		Issue_Date						DATE                    NOT NULL,
		Issue_Time					    TIME					NOT NULL,
		
		CONSTRAINT pk_IN_PATIENT_REPORT PRIMARY KEY ( In_Patient_Report_No ),
		CONSTRAINT fk_IN_PATIENT_REPORT FOREIGN KEY ( Admission_Number ) REFERENCES  IN_PATIENT 
		ON DELETE CASCADE
	);

	--INSERT VALUES INTO IN PATIENT LABORATORY REPORTS TABLE

	INSERT INTO IN_PATIENT_REPORT VALUES ('AD0001', ' ', SYSDATETIME(), SYSDATETIME())
	INSERT INTO IN_PATIENT_REPORT VALUES ('AD0002', ' ', SYSDATETIME(), SYSDATETIME())
	INSERT INTO IN_PATIENT_REPORT VALUES ('AD0003', ' ', SYSDATETIME(), SYSDATETIME())
	INSERT INTO IN_PATIENT_REPORT VALUES ('AD0004', ' ', SYSDATETIME(), SYSDATETIME())

	--CREATE TABLE OUT PATIENT LABORATORY REPORT

	--**********************************************
	--			Execute 30
	--**********************************************

	CREATE TABLE OUT_PATIENT_REPORT
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Out_Patient_Report_No AS 'OR' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Patient_Id_Number				INT						NOT NULL,	
		Report                          IMAGE                   NOT NULL,
		Issue_Date						DATE                    NOT NULL,
		Issue_Time					    TIME					NOT NULL,
		
		CONSTRAINT pk_OUT_PATIENT_REPORT PRIMARY KEY ( Out_Patient_Report_No ),
		CONSTRAINT fk_OUT_PATIENT_REPORT FOREIGN KEY ( Patient_Id_Number ) REFERENCES PATIENT_PRIVATE_DETAIL 
		ON DELETE CASCADE
	);

	INSERT INTO OUT_PATIENT_REPORT  VALUES (1, ' ', SYSDATETIME(), SYSDATETIME())
	INSERT INTO OUT_PATIENT_REPORT  VALUES (1, ' ', SYSDATETIME(), SYSDATETIME())
	INSERT INTO OUT_PATIENT_REPORT  VALUES (2, ' ', SYSDATETIME(), SYSDATETIME())
	INSERT INTO OUT_PATIENT_REPORT  VALUES (3, ' ', SYSDATETIME(), SYSDATETIME())
	INSERT INTO OUT_PATIENT_REPORT  VALUES (5, ' ', SYSDATETIME(), SYSDATETIME())


	--CREATE TABLE FOR X RAY ROOM

	--**********************************************
	--			Execute 31
	--**********************************************

	CREATE TABLE X_RAY_ROOM
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Staff_Id AS 'X' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		X_Officer_First_Name				VARCHAR (200)			NOT NULL,
		X_Officer_Middle_Name				VARCHAR (200)					,
		X_Officer_Last_Name				VARCHAR (200)			NOT NULL,
		X_Officer_Address			    VARCHAR (150)           NOT NULL,
		X_Officer_Tele_Number			INT	                    NOT NULL,
		X_Officer_DOB				    DATE                    NOT NULL,
		X_Officer_Salary				DECIMAL                 NOT NULL,
		Designation						VARCHAR (30)			NOT NULL,
		X_Job_Start_Date			    DATE                    NOT NULL,
	
		CONSTRAINT pk_X_RAY_ROOM PRIMARY KEY ( Staff_Id )              
	);

	--INSERT VALUES INTO X RAY ROOM STAFF TABLE

	INSERT INTO X_RAY_ROOM VALUES ('WAYOMI'  ,'NISANSALA','DAHANAYAKA'   , 'NO,29 TANGALLE'     , 0717575643, '1996.06.19', '54000.50', 'RADIOLOGY' , '2016.09.01')
	INSERT INTO X_RAY_ROOM VALUES ('MADAWA'  ,'SASHIKA'  ,'PERERA'       , 'WELIGAMA RD MATARA' , 0778787545, '1995.02.16', '87000.50', 'RADIOLOGY' , '2018.05.19')
	INSERT INTO X_RAY_ROOM VALUES ('NALIN'   ,'NIMALKA'  ,'DISANAYAKA'   , 'NO,17 PANADURA'     , 0768771231, '1986.01.29', '59000.50', 'RADIOLOGY' , '2018.10.02')
	INSERT INTO X_RAY_ROOM VALUES ('NISHADI' ,'HANSANI'  ,'WARNASEKARA'  , 'KATUBEDDA MORATUWA' , 0713434787, '1989.05.19', '52000.00', 'RADIOLOGY' , '2017.05.01')
	INSERT INTO X_RAY_ROOM VALUES ('CHATHURA','SACHITH ' ,'JAYASEKARA'   , 'NO,54 HOMAGAMA'     , 0760098090, '1998.08.21', '51000.50', 'RADIOLOGY' , '2019.12.22')


	--CREATE TABLE FOR IN PATIENT X RAY

	--**********************************************
	--			Execute 32
	--**********************************************

	CREATE TABLE IN_PATIENT_XRAY
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		In_Patient_X_Ray_No AS 'IX' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Admission_Number				VARCHAR    ( 9)			NOT NULL,
		X_Ray                           IMAGE                   NOT NULL,
		Issue_Date						DATE                    NOT NULL,
		Issue_Time					    TIME					NOT NULL,
		Ward_Number						CHAR    (10)            NOT NULL,
		Room_Number						CHAR    (10)            NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,

		CONSTRAINT pk_IN_PATIENT_XRAY PRIMARY KEY ( In_Patient_X_Ray_No ),
		CONSTRAINT fk_IN_PATIENT_XRAY FOREIGN KEY ( Admission_Number ) REFERENCES  IN_PATIENT,
									  FOREIGN KEY ( Ward_Number ) REFERENCES WARD,
									  FOREIGN KEY ( Room_Number ) REFERENCES ROOM,
									  FOREIGN KEY ( Specialist_Doctor_Id ) REFERENCES SPECIALIST_DOCTOR
									  ON DELETE CASCADE
									  
	);


	--INSERT VALUES INTO IN PATIENT X RAY TABLE

	INSERT INTO IN_PATIENT_XRAY VALUES ('AD0001', '', SYSDATETIME(),SYSDATETIME(), 'W01', 'R001', 'SD0001')
	INSERT INTO IN_PATIENT_XRAY VALUES ('AD0002', '', SYSDATETIME(),SYSDATETIME(), 'W01', 'R002', 'SD0001')
	INSERT INTO IN_PATIENT_XRAY VALUES ('AD0003', '', SYSDATETIME(),SYSDATETIME(), 'W02', 'R003', 'SD0005')
	INSERT INTO IN_PATIENT_XRAY VALUES ('AD0004', '', SYSDATETIME(),SYSDATETIME(), 'W03', 'R004', 'SD0001')
	INSERT INTO IN_PATIENT_XRAY VALUES ('AD0005', '', SYSDATETIME(),SYSDATETIME(), 'W04', 'R005', 'SD0003')


	--CREATE TABLE FOR OUT PATIENT X-RAY

	--**********************************************
	--			Execute 33
	--**********************************************

	CREATE TABLE OUT_PATIENT_XRAY
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Out_Patient_Xray_No AS 'OX' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Patient_Id_Number				INT						NOT NULL,	
		X_Ray                           IMAGE                   NOT NULL,
		Issue_Date						DATE                    NOT NULL,
		Issue_Time					    TIME					NOT NULL,
		
		CONSTRAINT pk_OUT_PATIENT_XRAY PRIMARY KEY ( Out_Patient_Xray_No ),
		CONSTRAINT fk_OUT_PATIENT_XRAY FOREIGN KEY ( Patient_Id_Number ) REFERENCES PATIENT_PRIVATE_DETAIL 
		ON DELETE CASCADE
	);

	--INSERT VALUES INTO OUT PATIENT X RAY TABLE

	INSERT INTO OUT_PATIENT_XRAY VALUES (1, '', SYSDATETIME(),SYSDATETIME())
	INSERT INTO OUT_PATIENT_XRAY VALUES (1, '', SYSDATETIME(),SYSDATETIME())
	INSERT INTO OUT_PATIENT_XRAY VALUES (2, '', SYSDATETIME(),SYSDATETIME())
	INSERT INTO OUT_PATIENT_XRAY VALUES (3, '', SYSDATETIME(),SYSDATETIME())
	INSERT INTO OUT_PATIENT_XRAY VALUES (4, '', SYSDATETIME(),SYSDATETIME())


	--CREATE TABLE SCAN ROOM

	--**********************************************
	--			Execute 34
	--**********************************************

	CREATE TABLE SCAN_ROOM
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		S_Staff_Id AS 'SC' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		S_Officer_First_Name			VARCHAR (200)			NOT NULL,
		S_Officer_Middle_Name			VARCHAR (200)					,
		S_Officer_Last_Name				VARCHAR (200)			NOT NULL,
		S_Officer_Address			    VARCHAR (150)           NOT NULL,
		S_Officer_Tele_Number			INT	                    NOT NULL,
		S_Officer_DOB				    DATE                    NOT NULL,
		S_Officer_Salary				DECIMAL                 NOT NULL,
		Designation						VARCHAR (30)			NOT NULL,
		S_Job_Start_Date			    DATE                    NOT NULL,
	
		CONSTRAINT pk_SCAN_ROOM PRIMARY KEY ( S_Staff_Id )              
	);

	--INSERT VALUES INTO TABLE SCAN ROOM

	INSERT INTO SCAN_ROOM VALUES ('WAYOMI'  ,'NISANSALA','DAHANAYAKA'  , 'NO,29 TANGALLE'     , 0717575643, '1996.06.19', '54000.50', 'RADIOLOGY' , '2016.09.01')
	INSERT INTO SCAN_ROOM VALUES ('MADAWA'  ,'SASHIKA ' ,'PERERA'      , 'WELIGAMA RD MATARA' , 0778787545, '1995.02.16', '87000.50', 'RADIOLOGY' , '2018.05.19')
	INSERT INTO SCAN_ROOM VALUES ('NALIN'   ,'NIMALKA ' ,'DISANAYAKA'  , 'NO,17 PANADURA'     , 0768771231, '1986.01.29', '59000.50', 'RADIOLOGY' , '2018.10.02')
	INSERT INTO SCAN_ROOM VALUES ('NISHADI' ,'HANSANI ' ,'WARNASEKARA' , 'KATUBEDDA MORATUWA' , 0713434787, '1989.05.19', '52000.00', 'RADIOLOGY' , '2017.05.01')
	INSERT INTO SCAN_ROOM VALUES ('CHATHURA','SACHITH ' ,'JAYASEKARA'  , 'NO,54 HOMAGAMA'     , 0760098090, '1998.08.21', '51000.50', 'RADIOLOGY' , '2019.12.22')


	--CREATE TABLE IN PATIENT SCAN 

	--**********************************************
	--			Execute 35
	--**********************************************

	CREATE TABLE IN_PATIENT_SCAN
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		In_Patient_Scan_No AS 'IS' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Admission_Number				VARCHAR    (9)			NOT NULL,
		Scan_Report                     IMAGE                   NOT NULL,
		Issue_Date						DATE                    NOT NULL,
		Issue_Time					    TIME					NOT NULL,
		Ward_Number						CHAR    (10)            NOT NULL,
		Room_Number						CHAR    (10)            NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,

		CONSTRAINT pk_IN_PATIENT_SCAN PRIMARY KEY ( In_Patient_Scan_No ),
		CONSTRAINT fk_IN_PATIENT_SCAN FOREIGN KEY ( Admission_Number ) REFERENCES  IN_PATIENT,
									  FOREIGN KEY ( Ward_Number ) REFERENCES WARD,
									  FOREIGN KEY ( Room_Number ) REFERENCES ROOM,
									  FOREIGN KEY ( Specialist_Doctor_Id ) REFERENCES SPECIALIST_DOCTOR
									  ON DELETE CASCADE
									  
	);

	--INSERT VALUES INTO IN PATIENT SCAN REPORTS

	INSERT INTO IN_PATIENT_SCAN VALUES ('AD0001', '', SYSDATETIME(),SYSDATETIME(), 'W01', 'R001', 'SD0001')
	INSERT INTO IN_PATIENT_SCAN VALUES ('AD0002', '', SYSDATETIME(),SYSDATETIME(), 'W01', 'R002', 'SD0001')
	INSERT INTO IN_PATIENT_SCAN VALUES ('AD0003', '', SYSDATETIME(),SYSDATETIME(), 'W02', 'R003', 'SD0005')
	INSERT INTO IN_PATIENT_SCAN VALUES ('AD0004', '', SYSDATETIME(),SYSDATETIME(), 'W03', 'R004', 'SD0001')
	INSERT INTO IN_PATIENT_SCAN VALUES ('AD0005', '', SYSDATETIME(),SYSDATETIME(), 'W04', 'R005', 'SD0003')

	
	--CREATE TABLE OUT PATIENT SCAN 

	--**********************************************
	--			Execute 36
	--**********************************************

	CREATE TABLE OUT_PATIENT_SCAN
	(
		Number							INT		IDENTITY (1,1)  NOT NULL, 

		Out_Patient_Scan_No AS 'OS' + RIGHT('000' + CAST (Number AS VARCHAR(10)),7) PERSISTED,

		Patient_Id_Number				INT						NOT NULL,	
		Scan_Report                     IMAGE                   NOT NULL,
		Issue_Date						DATE                    NOT NULL,
		Issue_Time					    TIME					NOT NULL,
		Specialist_Doctor_Id			VARCHAR ( 9)			NOT NULL,

		CONSTRAINT pk_OUT_PATIENT_SCAN PRIMARY KEY ( Out_Patient_Scan_No ),
		CONSTRAINT fk_OUT_PATIENT_SCAN FOREIGN KEY ( Patient_Id_Number ) REFERENCES PATIENT_PRIVATE_DETAIL,
																		 FOREIGN KEY ( Specialist_Doctor_Id ) REFERENCES SPECIALIST_DOCTOR
																		 ON DELETE CASCADE
																		 
	);

	--INSERT INTO VALUES OUT PATIENT SCAN REPORTS

	INSERT INTO OUT_PATIENT_SCAN VALUES (1, '', SYSDATETIME(),SYSDATETIME() ,'SD0001')
	INSERT INTO OUT_PATIENT_SCAN VALUES (1, '', SYSDATETIME(),SYSDATETIME() ,'SD0002')
	INSERT INTO OUT_PATIENT_SCAN VALUES (2, '', SYSDATETIME(),SYSDATETIME() ,'SD0003')
	INSERT INTO OUT_PATIENT_SCAN VALUES (3, '', SYSDATETIME(),SYSDATETIME() ,'SD0001')
	INSERT INTO OUT_PATIENT_SCAN VALUES (4, '', SYSDATETIME(),SYSDATETIME() ,'SD0004')

	--CREATE TABLE FOR ALL REPORTS OF IN PATIENTS

	--**********************************************
	--			Execute 37
	--**********************************************

	CREATE TABLE REPORT_IN_PATIENT
	(
		Admission_Number				VARCHAR ( 9)			NOT NULL,
		In_Patient_Report_No			VARCHAR ( 9)					,
		In_Patient_Xray_No              VARCHAR ( 9)                    ,
		In_Patient_Scan_No				VARCHAR ( 9)                    ,

		CONSTRAINT pk_REPORT_IN_PATIENT PRIMARY KEY ( Admission_Number, In_Patient_Report_No ),
		CONSTRAINT fk_REPORT_IN_PATIENT FOREIGN KEY ( Admission_Number ) REFERENCES  IN_PATIENT,
										FOREIGN KEY ( In_Patient_Report_No ) REFERENCES IN_PATIENT_REPORT ,
										FOREIGN KEY ( In_Patient_Xray_No )   REFERENCES IN_PATIENT_XRAY ,
										FOREIGN KEY ( In_Patient_Scan_No )   REFERENCES IN_PATIENT_SCAN
										ON DELETE CASCADE
										
	);


	--CREATE TABLE FOR ALL REPORTS OF OUT PATIENTS

	--**********************************************
	--			Execute 37
	--**********************************************

	CREATE TABLE REPORT_OUT_PATIENT
	(
		Out_Patient_Id_Number			INT						NOT NULL,
		Out_Patient_Report_No			VARCHAR ( 9)					,
		Out_Patient_Xray_No				VARCHAR ( 9)					,
		Out_Patient_Scan_No				VARCHAR ( 9)					,

		CONSTRAINT pk_REPORT_OUT_PATIENT PRIMARY KEY ( Out_Patient_Id_Number, Out_Patient_Report_No ),
		CONSTRAINT fk_REPORT_OUT_PATIENT FOREIGN KEY ( Out_Patient_Id_Number ) REFERENCES OUT_PATIENT ,
										 FOREIGN KEY ( Out_Patient_Report_No ) REFERENCES OUT_PATIENT_REPORT,
										 FOREIGN KEY ( Out_Patient_Xray_No )   REFERENCES OUT_PATIENT_XRAY,
										 FOREIGN KEY ( Out_Patient_Scan_No )   REFERENCES OUT_PATIENT_SCAN 
										 ON DELETE CASCADE
										 
	);






