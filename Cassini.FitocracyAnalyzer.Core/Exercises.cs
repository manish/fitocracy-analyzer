using System;
using System.ComponentModel;

namespace Cassini.FitocracyAnalyzer.Core
{
	public enum Exercises
	{
		[Description("2-Arm Dumbbell Preacher Curl")]
		TwoArmDumbbellPreacherCurl,

		[Description("30-Day Shred")]
		ThreeZeroDayShred,

		[Description("360 Twist Jump")]
		ThreeSixZeroTwistJump,

		[Description("Ab Wheel (kneeling)")]
		AbWheelkneeling,

		[Description("Ab Wheel (standing)")]
		AbWheelstanding,

		[Description("Abductor Machine")]
		AbductorMachine,

		[Description("Adductor Machine")]
		AdductorMachine,

		[Description("Advanced Sumo Squat")]
		AdvancedSumoSquat,

		[Description("Advanced Tuck Planche")]
		AdvancedTuckPlanche,

		[Description("Advanced Tuck Planche Push-Up")]
		AdvancedTuckPlanchePushUp,

		[Description("Adventure Racing")]
		AdventureRacing,

		[Description("Aerobic Dance Class")]
		AerobicDanceClass,

		[Description("Aerobics Class")]
		AerobicsClass,

		[Description("Aikido")]
		Aikido,

		[Description("Alpha Press")]
		AlphaPress,

		[Description("Alternate Hammer Dumbbell Curl")]
		AlternateHammerDumbbellCurl,

		[Description("Alternate Incline Dumbbell Curl")]
		AlternateInclineDumbbellCurl,

		[Description("Alternating Body Weight Reverse Lunge")]
		AlternatingBodyWeightReverseLunge,

		[Description("Alternating Floor Press")]
		AlternatingFloorPress,

		[Description("Alternating Hang Clean")]
		AlternatingHangClean,

		[Description("Alternating Kettlebell Hang Clean")]
		AlternatingKettlebellHangClean,

		[Description("Alternating Kettlebell Press")]
		AlternatingKettlebellPress,

		[Description("Alternating Kettlebell Row")]
		AlternatingKettlebellRow,

		[Description("Alternating One-Leg Hip Thrust")]
		AlternatingOneLegHipThrust,

		[Description("Alternating V-Up")]
		AlternatingVUp,

		[Description("American Football")]
		AmericanFootball,

		[Description("Angled Bridge")]
		AngledBridge,

		[Description("Anusara Yoga")]
		AnusaraYoga,

		[Description("Aqua Aerobics")]
		AquaAerobics,

		[Description("Arch Back Good Morning")]
		ArchBackGoodMorning,

		[Description("Archery")]
		Archery,

		[Description("Arnold Dumbbell Press")]
		ArnoldDumbbellPress,

		[Description("Around The Worlds")]
		AroundTheWorlds,

		[Description("Ashtanga")]
		Ashtanga,

		[Description("Assisted One-Arm Pull-Up")]
		AssistedOneArmPullUp,

		[Description("Atlas Stones")]
		AtlasStones,

		[Description("Badminton")]
		Badminton,

		[Description("Ball Slams")]
		BallSlams,

		[Description("Ballet")]
		Ballet,

		[Description("Ballroom Dancing")]
		BallroomDancing,

		[Description("Band Assisted Chin-Up")]
		BandAssistedChinUp,

		[Description("Band Chest Press")]
		BandChestPress,

		[Description("Band Hip Extension")]
		BandHipExtension,

		[Description("Band Hip Hinge Row")]
		BandHipHingeRow,

		[Description("Band Hip Series")]
		BandHipSeries,

		[Description("Band Kneel Stand")]
		BandKneelStand,

		[Description("Band Kneeling One-Arm Lat Pulldown")]
		BandKneelingOneArmLatPulldown,

		[Description("Band Kneeling Straight Arm Lat Pulldown")]
		BandKneelingStraightArmLatPulldown,

		[Description("Band Pull Aparts")]
		BandPullAparts,

		[Description("Band Quadruped Donkey Kick")]
		BandQuadrupedDonkeyKick,

		[Description("Band Rear Delt Fly")]
		BandRearDeltFly,

		[Description("Band Rear Delt Row")]
		BandRearDeltRow,

		[Description("Band Resisted Dowel Hip Hinge")]
		BandResistedDowelHipHinge,

		[Description("Band Squat to Press")]
		BandSquattoPress,

		[Description("Band Trap Raise")]
		BandTrapRaise,

		[Description("Band Windmill")]
		BandWindmill,

		[Description("Band-Resisted Prayer Press")]
		BandResistedPrayerPress,

		[Description("Band-Resisted Push-Up")]
		BandResistedPushUp,

		[Description("Baptiste Power Vinyasa Yoga")]
		BaptistePowerVinyasaYoga,

		[Description("Barbell Bench Press")]
		BarbellBenchPress,

		[Description("Barbell Bent Press")]
		BarbellBentPress,

		[Description("Barbell Box Squat")]
		BarbellBoxSquat,

		[Description("Barbell Bulgarian Split Squat")]
		BarbellBulgarianSplitSquat,

		[Description("Barbell Corner Row")]
		BarbellCornerRow,

		[Description("Barbell Curl")]
		BarbellCurl,

		[Description("Barbell Curls Lying Against An Incline")]
		BarbellCurlsLyingAgainstAnIncline,

		[Description("Barbell Deadlift")]
		BarbellDeadlift,

		[Description("Barbell Floor Press")]
		BarbellFloorPress,

		[Description("Barbell Glute Bridge")]
		BarbellGluteBridge,

		[Description("Barbell Hip Thrust")]
		BarbellHipThrust,

		[Description("Barbell Incline Bench Press")]
		BarbellInclineBenchPress,

		[Description("Barbell Incline Shoulder Raise")]
		BarbellInclineShoulderRaise,

		[Description("Barbell Jump Squat")]
		BarbellJumpSquat,

		[Description("Barbell Lunges")]
		BarbellLunges,

		[Description("Barbell Pin Press")]
		BarbellPinPress,

		[Description("Barbell Rear Delt Row")]
		BarbellRearDeltRow,

		[Description("Barbell Rear Lunge")]
		BarbellRearLunge,

		[Description("Barbell Seated Calf Raise")]
		BarbellSeatedCalfRaise,

		[Description("Barbell Shrug")]
		BarbellShrug,

		[Description("Barbell Shrug Behind The Back")]
		BarbellShrugBehindTheBack,

		[Description("Barbell Side Bend")]
		BarbellSideBend,

		[Description("Barbell Slideboard Reverse Lunge")]
		BarbellSlideboardReverseLunge,

		[Description("Barbell Split Squat")]
		BarbellSplitSquat,

		[Description("Barbell Squat")]
		BarbellSquat,

		[Description("Barbell Squats on the Bosu Ball")]
		BarbellSquatsontheBosuBall,

		[Description("Barbell Step Ups")]
		BarbellStepUps,

		[Description("Baseball")]
		Baseball,

		[Description("Basketball")]
		Basketball,

		[Description("Battle Ropes")]
		BattleRopes,

		[Description("Battled Hurricane Sandy")]
		BattledHurricaneSandy,

		[Description("Beach Volleyball")]
		BeachVolleyball,

		[Description("Bear Crawl")]
		BearCrawl,

		[Description("Behind the Neck Push Press")]
		BehindtheNeckPushPress,

		[Description("Belly Boarding")]
		BellyBoarding,

		[Description("Belly Dancing")]
		BellyDancing,

		[Description("Bench Dip (Seated Dip)")]
		BenchDipSeatedDip,

		[Description("Bench Dips")]
		BenchDips,

		[Description("Bench Press Lockout")]
		BenchPressLockout,

		[Description("Bent Over Band Row")]
		BentOverBandRow,

		[Description("Bent Over Barbell Row")]
		BentOverBarbellRow,

		[Description("Bent Over Low-Pulley Side Lateral")]
		BentOverLowPulleySideLateral,

		[Description("Bent Over Two-Dumbbell Row")]
		BentOverTwoDumbbellRow,

		[Description("Bent Over Two-Dumbbell Row With Palms In")]
		BentOverTwoDumbbellRowWithPalmsIn,

		[Description("Bent-Arm Barbell Pullover")]
		BentArmBarbellPullover,

		[Description("Bent-Arm Dumbbell Pullover")]
		BentArmDumbbellPullover,

		[Description("Bent-Knee Hip Extension Cross")]
		BentKneeHipExtensionCross,

		[Description("Bent-Over Rear Delt Raise")]
		BentOverRearDeltRaise,

		[Description("Bicycle")]
		Bicycle,

		[Description("Bikram / Hot Yoga")]
		BikramHotYoga,

		[Description("Bird Dog")]
		BirdDog,

		[Description("Blackbird")]
		Blackbird,

		[Description("Boat Sit")]
		BoatSit,

		[Description("Body Pump Class")]
		BodyPumpClass,

		[Description("Body Weight Assisted One-Leg Squat")]
		BodyWeightAssistedOneLegSquat,

		[Description("Body Weight Bulgarian Split Squat")]
		BodyWeightBulgarianSplitSquat,

		[Description("Body Weight Close Squat")]
		BodyWeightCloseSquat,

		[Description("Body Weight Deficit Reverse Lunge")]
		BodyWeightDeficitReverseLunge,

		[Description("Body Weight Dip Station L-sit")]
		BodyWeightDipStationLsit,

		[Description("Body Weight Glute Hamstring Raise")]
		BodyWeightGluteHamstringRaise,

		[Description("Body Weight Glute March")]
		BodyWeightGluteMarch,

		[Description("Body Weight Half Squat")]
		BodyWeightHalfSquat,

		[Description("Body Weight Heel Reverse Lunge")]
		BodyWeightHeelReverseLunge,

		[Description("Body Weight Hip Hinge")]
		BodyWeightHipHinge,

		[Description("Body Weight Hip Thrust")]
		BodyWeightHipThrust,

		[Description("Body Weight Inverted Row (Let Me Ups)")]
		BodyWeightInvertedRowLetMeUps,

		[Description("Body Weight Jackknife Squat")]
		BodyWeightJackknifeSquat,

		[Description("Body Weight Low Box Squat")]
		BodyWeightLowBoxSquat,

		[Description("Body Weight Lunge")]
		BodyWeightLunge,

		[Description("Body Weight One Half One-Leg Squat")]
		BodyWeightOneHalfOneLegSquat,

		[Description("Body Weight One-Leg Squat")]
		BodyWeightOneLegSquat,

		[Description("Body Weight Ring L-sit")]
		BodyWeightRingLsit,

		[Description("Body Weight Ring Push-Up")]
		BodyWeightRingPushUp,

		[Description("Body Weight Ring Row")]
		BodyWeightRingRow,

		[Description("Body Weight Shoulderstand Squat")]
		BodyWeightShoulderstandSquat,

		[Description("Body Weight Side Step Up")]
		BodyWeightSideStepUp,

		[Description("Body Weight Split Squat")]
		BodyWeightSplitSquat,

		[Description("Body Weight Split Squat Isometric Hold")]
		BodyWeightSplitSquatIsometricHold,

		[Description("Body Weight Squat")]
		BodyWeightSquat,

		[Description("Body Weight Squat Curtsy Lunge")]
		BodyWeightSquatCurtsyLunge,

		[Description("Body Weight Step-Down Reverse Lunge")]
		BodyWeightStepDownReverseLunge,

		[Description("Body Weight Straight Leg Hip Thrust")]
		BodyWeightStraightLegHipThrust,

		[Description("Body Weight Sumo Squat")]
		BodyWeightSumoSquat,

		[Description("Body Weight Supported Squat")]
		BodyWeightSupportedSquat,

		[Description("Body Weight Uneven Squat")]
		BodyWeightUnevenSquat,

		[Description("Body Weight Walking Lunge Into One-Leg Romanian Deadlift")]
		BodyWeightWalkingLungeIntoOneLegRomanianDeadlift,

		[Description("Body Weight Wall Squat")]
		BodyWeightWallSquat,

		[Description("Bodycombat Class")]
		BodycombatClass,

		[Description("Bodysaw")]
		Bodysaw,

		[Description("Boot Camp")]
		BootCamp,

		[Description("Bottoms Up Kettlebell Clean and Press")]
		BottomsUpKettlebellCleanandPress,

		[Description("Bottoms Up Kettlebell Press")]
		BottomsUpKettlebellPress,

		[Description("Bottoms-Up Clean From The Hang Position")]
		BottomsUpCleanFromTheHangPosition,

		[Description("Box Jump Overs")]
		BoxJumpOvers,

		[Description("Box Jumps")]
		BoxJumps,

		[Description("Boxing")]
		Boxing,

		[Description("Brazilian Jiu-Jitsu")]
		BrazilianJiuJitsu,

		[Description("Break Dancing")]
		BreakDancing,

		[Description("Broomball")]
		Broomball,

		[Description("Burpee")]
		Burpee,

		[Description("Butt Kickers")]
		ButtKickers,

		[Description("Cable Backhand")]
		CableBackhand,

		[Description("Cable Cross Squats")]
		CableCrossSquats,

		[Description("Cable Crossover")]
		CableCrossover,

		[Description("Cable Crunch")]
		CableCrunch,

		[Description("Cable External Rotation")]
		CableExternalRotation,

		[Description("Cable Hammer Curls - Rope Attachment")]
		CableHammerCurlsRopeAttachment,

		[Description("Cable Hip Adduction")]
		CableHipAdduction,

		[Description("Cable Incline Triceps Extension")]
		CableInclineTricepsExtension,

		[Description("Cable Lying Triceps Extension")]
		CableLyingTricepsExtension,

		[Description("Cable One Arm Tricep Extension")]
		CableOneArmTricepExtension,

		[Description("Cable Preacher Curl")]
		CablePreacherCurl,

		[Description("Cable Pull Through")]
		CablePullThrough,

		[Description("Cable Rope Overhead Triceps Extension")]
		CableRopeOverheadTricepsExtension,

		[Description("Cable Rope Rear-Delt Rows")]
		CableRopeRearDeltRows,

		[Description("Cable Seated Lateral Raise")]
		CableSeatedLateralRaise,

		[Description("Cable Shrug")]
		CableShrug,

		[Description("Cable Twist")]
		CableTwist,

		[Description("Cable Wrist Curl")]
		CableWristCurl,

		[Description("Calf Press On The Leg Press Machine")]
		CalfPressOnTheLegPressMachine,

		[Description("Calf-Machine Shoulder Shrug")]
		CalfMachineShoulderShrug,

		[Description("Capoeira")]
		Capoeira,

		[Description("Car Deadlift")]
		CarDeadlift,

		[Description("Child's Pose T Spine Rotation")]
		ChildsPoseTSpineRotation,

		[Description("Chin Na")]
		ChinNa,

		[Description("Chin-Up")]
		ChinUp,

		[Description("Clap Push-Up")]
		ClapPushUp,

		[Description("Clean")]
		Clean,

		[Description("Clean Pull")]
		CleanPull,

		[Description("Clean and Jerk")]
		CleanandJerk,

		[Description("Clean and Press")]
		CleanandPress,

		[Description("Close Grip Chin-Up")]
		CloseGripChinUp,

		[Description("Close Grip Pull-Up")]
		CloseGripPullUp,

		[Description("Close Grip Push-Up")]
		CloseGripPushUp,

		[Description("Close Handstand Push-Up")]
		CloseHandstandPushUp,

		[Description("Close-Grip Barbell Bench Press")]
		CloseGripBarbellBenchPress,

		[Description("Close-Grip EZ Bar Curl")]
		CloseGripEZBarCurl,

		[Description("Close-Grip Front Lat Pulldown")]
		CloseGripFrontLatPulldown,

		[Description("Close-Grip Standing Barbell Curl")]
		CloseGripStandingBarbellCurl,

		[Description("Closing Bridge")]
		ClosingBridge,

		[Description("Coccoon Crunch")]
		CoccoonCrunch,

		[Description("Conan's Wheel")]
		ConansWheel,

		[Description("Concentration Curls")]
		ConcentrationCurls,

		[Description("Core Twist Push-Up")]
		CoreTwistPushUp,

		[Description("Corn Cob Pull-Up")]
		CornCobPullUp,

		[Description("Corner Barbell Press (Lumberjack Press)")]
		CornerBarbellPressLumberjackPress,

		[Description("Countermovement Drop")]
		CountermovementDrop,

		[Description("Country-Western Dancing")]
		CountryWesternDancing,

		[Description("Crab Walk")]
		CrabWalk,

		[Description("Crocodile Belly Breathing")]
		CrocodileBellyBreathing,

		[Description("Cross Body Hammer Dumbbell Curl")]
		CrossBodyHammerDumbbellCurl,

		[Description("Cross Country Skiing")]
		CrossCountrySkiing,

		[Description("Crossover Reverse Lunge")]
		CrossoverReverseLunge,

		[Description("Crow Stand")]
		CrowStand,

		[Description("Crumping")]
		Crumping,

		[Description("Crunch")]
		Crunch,

		[Description("Cuban Press")]
		CubanPress,

		[Description("Curling")]
		Curling,

		[Description("Curls in the Squat Rack")]
		CurlsintheSquatRack,

		[Description("Cycling")]
		Cycling,

		[Description("Cycling (stationary)")]
		Cyclingstationary,

		[Description("Dead Bug")]
		DeadBug,

		[Description("Decline Barbell Bench Press")]
		DeclineBarbellBenchPress,

		[Description("Decline Close-Grip Bench To Skull Crusher")]
		DeclineCloseGripBenchToSkullCrusher,

		[Description("Decline Crunch")]
		DeclineCrunch,

		[Description("Decline Dumbbell Bench Press")]
		DeclineDumbbellBenchPress,

		[Description("Decline Dumbbell Flyes")]
		DeclineDumbbellFlyes,

		[Description("Decline Dumbbell Triceps Extension")]
		DeclineDumbbellTricepsExtension,

		[Description("Decline EZ Bar Triceps Extension")]
		DeclineEZBarTricepsExtension,

		[Description("Decline Push-Up")]
		DeclinePushUp,

		[Description("Deficit Barbell Deadlift")]
		DeficitBarbellDeadlift,

		[Description("Deficit Trap Bar Deadlift")]
		DeficitTrapBarDeadlift,

		[Description("Diamond Push-Up")]
		DiamondPushUp,

		[Description("Dimel Deadlift")]
		DimelDeadlift,

		[Description("Dip Progression")]
		DipProgression,

		[Description("Dip Station Bent Leg Raise")]
		DipStationBentLegRaise,

		[Description("Dip Station Straight Leg Raise")]
		DipStationStraightLegRaise,

		[Description("Dips - Chest Version")]
		DipsChestVersion,

		[Description("Dips - Triceps Version")]
		DipsTricepsVersion,

		[Description("Divebomber Push-Up")]
		DivebomberPushUp,

		[Description("Dodgeball")]
		Dodgeball,

		[Description("Donkey Calf Raise")]
		DonkeyCalfRaise,

		[Description("Double Kettlebell Clean")]
		DoubleKettlebellClean,

		[Description("Double Kettlebell Clean and Press")]
		DoubleKettlebellCleanandPress,

		[Description("Double Kettlebell Jerk")]
		DoubleKettlebellJerk,

		[Description("Double Kettlebell Press")]
		DoubleKettlebellPress,

		[Description("Double Kettlebell Push Press")]
		DoubleKettlebellPushPress,

		[Description("Double Kettlebell Snatch")]
		DoubleKettlebellSnatch,

		[Description("Double Kettlebell Swing")]
		DoubleKettlebellSwing,

		[Description("Double Long Cycle")]
		DoubleLongCycle,

		[Description("Double Under Jump Rope")]
		DoubleUnderJumpRope,

		[Description("Downward Dog Spiderman Lunge")]
		DownwardDogSpidermanLunge,

		[Description("Dragon Boating")]
		DragonBoating,

		[Description("Dragon Flag")]
		DragonFlag,

		[Description("Drumming")]
		Drumming,

		[Description("Dumbbell 2-Arm Triceps Extension")]
		DumbbellTwoArmTricepsExtension,

		[Description("Dumbbell Bench Press")]
		DumbbellBenchPress,

		[Description("Dumbbell Bent Press")]
		DumbbellBentPress,

		[Description("Dumbbell Bicep Curl")]
		DumbbellBicepCurl,

		[Description("Dumbbell Bulgarian Split Squat")]
		DumbbellBulgarianSplitSquat,

		[Description("Dumbbell Deadlift")]
		DumbbellDeadlift,

		[Description("Dumbbell Floor Press")]
		DumbbellFloorPress,

		[Description("Dumbbell Flyes")]
		DumbbellFlyes,

		[Description("Dumbbell Goblet Lateral Lunge")]
		DumbbellGobletLateralLunge,

		[Description("Dumbbell Incline Shoulder Raise")]
		DumbbellInclineShoulderRaise,

		[Description("Dumbbell Lunges")]
		DumbbellLunges,

		[Description("Dumbbell Lying Pronation")]
		DumbbellLyingPronation,

		[Description("Dumbbell Lying Rear Lateral Raise")]
		DumbbellLyingRearLateralRaise,

		[Description("Dumbbell Lying Supination")]
		DumbbellLyingSupination,

		[Description("Dumbbell One-Arm Triceps Extension")]
		DumbbellOneArmTricepsExtension,

		[Description("Dumbbell Prone Incline Curl")]
		DumbbellProneInclineCurl,

		[Description("Dumbbell Rear Delt Row")]
		DumbbellRearDeltRow,

		[Description("Dumbbell Rear Lunge")]
		DumbbellRearLunge,

		[Description("Dumbbell Shrug")]
		DumbbellShrug,

		[Description("Dumbbell Side Bend")]
		DumbbellSideBend,

		[Description("Dumbbell Side Lateral Raise")]
		DumbbellSideLateralRaise,

		[Description("Dumbbell Side-Lying External Rotation")]
		DumbbellSideLyingExternalRotation,

		[Description("Dumbbell Side-Lying Internal Rotation")]
		DumbbellSideLyingInternalRotation,

		[Description("Dumbbell Slideboard Reverse Lunge")]
		DumbbellSlideboardReverseLunge,

		[Description("Dumbbell Split Clean")]
		DumbbellSplitClean,

		[Description("Dumbbell Split Clean and Jerk")]
		DumbbellSplitCleanandJerk,

		[Description("Dumbbell Split Squat")]
		DumbbellSplitSquat,

		[Description("Dumbbell Squat")]
		DumbbellSquat,

		[Description("Dumbbell Squat Clean")]
		DumbbellSquatClean,

		[Description("Dumbbell Squeeze Press")]
		DumbbellSqueezePress,

		[Description("Dumbbell Stability Ball Press")]
		DumbbellStabilityBallPress,

		[Description("Dumbbell Stationary Lunge")]
		DumbbellStationaryLunge,

		[Description("Dumbbell Step Ups")]
		DumbbellStepUps,

		[Description("EZ-Bar Curl")]
		EZBarCurl,

		[Description("Elbow-Supported Dumbbell External Rotation")]
		ElbowSupportedDumbbellExternalRotation,

		[Description("Elliptical Trainer")]
		EllipticalTrainer,

		[Description("Eskrima")]
		Eskrima,

		[Description("Exercise Ball Alternating Leg Lowers")]
		ExerciseBallAlternatingLegLowers,

		[Description("Exercise Ball Crunch")]
		ExerciseBallCrunch,

		[Description("Exercise Ball Hamstring Curl")]
		ExerciseBallHamstringCurl,

		[Description("Exercise Ball Knees to Chest")]
		ExerciseBallKneestoChest,

		[Description("Exercise Ball Rollout")]
		ExerciseBallRollout,

		[Description("Face Pull")]
		FacePull,

		[Description("Farmer's Walk")]
		FarmersWalk,

		[Description("Feet Elevated Glute Bridge")]
		FeetElevatedGluteBridge,

		[Description("Feet Elevated One-Leg Glute Bridge")]
		FeetElevatedOneLegGluteBridge,

		[Description("Feet Elevated Side Plank Abduction")]
		FeetElevatedSidePlankAbduction,

		[Description("Fencing")]
		Fencing,

		[Description("Field Hockey")]
		FieldHockey,

		[Description("Fire Hydrants")]
		FireHydrants,

		[Description("Flat Bench Cable Flyes")]
		FlatBenchCableFlyes,

		[Description("Flat Bent Leg Raise")]
		FlatBentLegRaise,

		[Description("Flat Frog Raise")]
		FlatFrogRaise,

		[Description("Flat Knee Raise")]
		FlatKneeRaise,

		[Description("Flat Straight Leg Raise")]
		FlatStraightLegRaise,

		[Description("Flexed-Arm Hang")]
		FlexedArmHang,

		[Description("Floor Wipers")]
		FloorWipers,

		[Description("Flutter Kicks")]
		FlutterKicks,

		[Description("Foam Rolling")]
		FoamRolling,

		[Description("Folk Dancing")]
		FolkDancing,

		[Description("Football (US Soccer)")]
		FootballUSSoccer,

		[Description("Forrest Yoga")]
		ForrestYoga,

		[Description("Forward Crawl")]
		ForwardCrawl,

		[Description("Frisbee")]
		Frisbee,

		[Description("Frog Jump to Push-Up")]
		FrogJumptoPushUp,

		[Description("Frog Stand")]
		FrogStand,

		[Description("Front Barbell Box Squat")]
		FrontBarbellBoxSquat,

		[Description("Front Barbell Squat")]
		FrontBarbellSquat,

		[Description("Front Cable Raise")]
		FrontCableRaise,

		[Description("Front Dumbbell Raise")]
		FrontDumbbellRaise,

		[Description("Front Grip Barbell Rear Lunge")]
		FrontGripBarbellRearLunge,

		[Description("Front Incline Dumbbell Raise")]
		FrontInclineDumbbellRaise,

		[Description("Front Leg Raises")]
		FrontLegRaises,

		[Description("Front Plate Raise")]
		FrontPlateRaise,

		[Description("Front Two-Dumbbell Raise")]
		FrontTwoDumbbellRaise,

		[Description("Full Bridge")]
		FullBridge,

		[Description("Full Zercher")]
		FullZercher,

		[Description("General CrossFit")]
		GeneralCrossFit,

		[Description("General Gymnastics")]
		GeneralGymnastics,

		[Description("General Insanity")]
		GeneralInsanity,

		[Description("General P90X")]
		GeneralPNoneZeroX,

		[Description("General Plyometrics")]
		GeneralPlyometrics,

		[Description("General Yoga")]
		GeneralYoga,

		[Description("Get Up Sit Up (Kettlebell)")]
		GetUpSitUpKettlebell,

		[Description("Glute Bridge")]
		GluteBridge,

		[Description("Glute Ham Sit Up")]
		GluteHamSitUp,

		[Description("Glute Kickback")]
		GluteKickback,

		[Description("Goblet Bulgarian Split Squat")]
		GobletBulgarianSplitSquat,

		[Description("Goblet Squat (dumbbell)")]
		GobletSquatdumbbell,

		[Description("Goblet Squat (kettlebell)")]
		GobletSquatkettlebell,

		[Description("Goblet Squat (medicine ball)")]
		GobletSquatmedicineball,

		[Description("Golf")]
		Golf,

		[Description("Groiners")]
		Groiners,

		[Description("Hack Squat")]
		HackSquat,

		[Description("Half Bridge")]
		HalfBridge,

		[Description("Half Chin-Up")]
		HalfChinUp,

		[Description("Half Handstand Push-Up")]
		HalfHandstandPushUp,

		[Description("Half Jump Squat")]
		HalfJumpSquat,

		[Description("Half Kneeling Dumbbell Shoulder Press")]
		HalfKneelingDumbbellShoulderPress,

		[Description("Half Kneeling Pallof Press")]
		HalfKneelingPallofPress,

		[Description("Half Kneeling Suitcase Isometric Hold")]
		HalfKneelingSuitcaseIsometricHold,

		[Description("Half One-arm Kneeling Cable Row")]
		HalfOnearmKneelingCableRow,

		[Description("Half Pull-Up")]
		HalfPullUp,

		[Description("Half Push-Up")]
		HalfPushUp,

		[Description("Half-Kneeling Anti-Rotation Chop")]
		HalfKneelingAntiRotationChop,

		[Description("Half-Kneeling Cable Lift")]
		HalfKneelingCableLift,

		[Description("Half-Kneeling One-Arm Landmine Press")]
		HalfKneelingOneArmLandminePress,

		[Description("Hammer Dumbbell Curl")]
		HammerDumbbellCurl,

		[Description("Hammer Grip Incline Dumbbell Bench Press")]
		HammerGripInclineDumbbellBenchPress,

		[Description("Hand Cycling")]
		HandCycling,

		[Description("Hand Gripper")]
		HandGripper,

		[Description("Hand Release Push Up")]
		HandReleasePushUp,

		[Description("Hand Switch with Push-Up")]
		HandSwitchwithPushUp,

		[Description("Hand Switches")]
		HandSwitches,

		[Description("Handstand")]
		Handstand,

		[Description("Handstand Push-Up")]
		HandstandPushUp,

		[Description("Handstand Push-Up Progression")]
		HandstandPushUpProgression,

		[Description("Hang Clean")]
		HangClean,

		[Description("Hang High Pull")]
		HangHighPull,

		[Description("Hang Power Clean")]
		HangPowerClean,

		[Description("Hang Power Snatch")]
		HangPowerSnatch,

		[Description("Hang Snatch")]
		HangSnatch,

		[Description("Hanging Bent Leg Raise")]
		HangingBentLegRaise,

		[Description("Hanging Frog Raise")]
		HangingFrogRaise,

		[Description("Hanging Knee Raise")]
		HangingKneeRaise,

		[Description("Hanging Straight Leg Raise")]
		HangingStraightLegRaise,

		[Description("Hapkido")]
		Hapkido,

		[Description("Hashing")]
		Hashing,

		[Description("Hatha")]
		Hatha,

		[Description("Head Bridge")]
		HeadBridge,

		[Description("Head Supported Dumbbell Row")]
		HeadSupportedDumbbellRow,

		[Description("Headstand")]
		Headstand,

		[Description("Heavy Bag")]
		HeavyBag,

		[Description("High Cable Curls")]
		HighCableCurls,

		[Description("High Knee March Isometric Hold")]
		HighKneeMarchIsometricHold,

		[Description("High Knees")]
		HighKnees,

		[Description("High Pull")]
		HighPull,

		[Description("Hiking")]
		Hiking,

		[Description("Hill Training")]
		HillTraining,

		[Description("Hip Belt Squats")]
		HipBeltSquats,

		[Description("Hip Hop Dancing")]
		HipHopDancing,

		[Description("Hip Raise Clam")]
		HipRaiseClam,

		[Description("Hollow Rock")]
		HollowRock,

		[Description("Horizontal Pull")]
		HorizontalPull,

		[Description("Horizontal Pull Progression")]
		HorizontalPullProgression,

		[Description("Horseback Riding")]
		HorsebackRiding,

		[Description("House Dancing")]
		HouseDancing,

		[Description("Hula Hooping")]
		HulaHooping,

		[Description("Hyperextension")]
		Hyperextension,

		[Description("Iaido")]
		Iaido,

		[Description("Ice Hockey")]
		IceHockey,

		[Description("Ice Skating")]
		IceSkating,

		[Description("Inch Worm")]
		InchWorm,

		[Description("Incline Barbell Triceps Extension")]
		InclineBarbellTricepsExtension,

		[Description("Incline Bench Pull")]
		InclineBenchPull,

		[Description("Incline Cable Flyes")]
		InclineCableFlyes,

		[Description("Incline Dumbbell Bench Press")]
		InclineDumbbellBenchPress,

		[Description("Incline Dumbbell Curl")]
		InclineDumbbellCurl,

		[Description("Incline Dumbbell Flyes")]
		InclineDumbbellFlyes,

		[Description("Incline Dumbbell Row")]
		InclineDumbbellRow,

		[Description("Incline Push-Up")]
		InclinePushUp,

		[Description("Indoor Volleyball")]
		IndoorVolleyball,

		[Description("Inline Skating")]
		InlineSkating,

		[Description("Integral Yoga")]
		IntegralYoga,

		[Description("Internal Shoulder Cuff Rotation (Lucky Cat)")]
		InternalShoulderCuffRotationLuckyCat,

		[Description("Inverted Row Isometric Hold")]
		InvertedRowIsometricHold,

		[Description("Iron Crosses (YAYOG)")]
		IronCrossesYAYOG,

		[Description("Isolateral Plate Loaded Decline Press")]
		IsolateralPlateLoadedDeclinePress,

		[Description("Isolateral Plate Loaded Incline Press")]
		IsolateralPlateLoadedInclinePress,

		[Description("Isolateral Plate Loaded Lat Pulldown")]
		IsolateralPlateLoadedLatPulldown,

		[Description("Isolateral Plate Loaded Press")]
		IsolateralPlateLoadedPress,

		[Description("Isolateral Plate Loaded Push Press")]
		IsolateralPlateLoadedPushPress,

		[Description("Isolateral Plate Loaded Row")]
		IsolateralPlateLoadedRow,

		[Description("Iyengar Yoga")]
		IyengarYoga,

		[Description("Jack Knife Sit-Up")]
		JackKnifeSitUp,

		[Description("Jackknife Pull")]
		JackknifePull,

		[Description("Javelin Press")]
		JavelinPress,

		[Description("Jazz Dancing")]
		JazzDancing,

		[Description("Jefferson Deadlift")]
		JeffersonDeadlift,

		[Description("Jerk")]
		Jerk,

		[Description("Jiu-Jitsu")]
		JiuJitsu,

		[Description("Jivamukti Yoga")]
		JivamuktiYoga,

		[Description("Judo")]
		Judo,

		[Description("Jump Lunges")]
		JumpLunges,

		[Description("Jump Rope")]
		JumpRope,

		[Description("Jump Squat (Toyotas)")]
		JumpSquatToyotas,

		[Description("Jump Squat Punch")]
		JumpSquatPunch,

		[Description("Jumping Jacks")]
		JumpingJacks,

		[Description("Karate")]
		Karate,

		[Description("Keg Carry")]
		KegCarry,

		[Description("Kempo")]
		Kempo,

		[Description("Kendo")]
		Kendo,

		[Description("Kettlebell Alternating Renegade Row")]
		KettlebellAlternatingRenegadeRow,

		[Description("Kettlebell Arnold Press")]
		KettlebellArnoldPress,

		[Description("Kettlebell Bent Press")]
		KettlebellBentPress,

		[Description("Kettlebell Clean and Press")]
		KettlebellCleanandPress,

		[Description("Kettlebell Crosswalk")]
		KettlebellCrosswalk,

		[Description("Kettlebell Dead Clean")]
		KettlebellDeadClean,

		[Description("Kettlebell Deadlift")]
		KettlebellDeadlift,

		[Description("Kettlebell Figure 8")]
		KettlebellFigureEight,

		[Description("Kettlebell Goatbag Hip Hinge to Wall")]
		KettlebellGoatbagHipHingetoWall,

		[Description("Kettlebell Halo")]
		KettlebellHalo,

		[Description("Kettlebell Hang Clean")]
		KettlebellHangClean,

		[Description("Kettlebell High Pull")]
		KettlebellHighPull,

		[Description("Kettlebell Leg Over Floor Press")]
		KettlebellLegOverFloorPress,

		[Description("Kettlebell Lunge")]
		KettlebellLunge,

		[Description("Kettlebell Lunge Pass Through")]
		KettlebellLungePassThrough,

		[Description("Kettlebell One-Leg Deadlift")]
		KettlebellOneLegDeadlift,

		[Description("Kettlebell Pirate Ships")]
		KettlebellPirateShips,

		[Description("Kettlebell Press")]
		KettlebellPress,

		[Description("Kettlebell Push Press")]
		KettlebellPushPress,

		[Description("Kettlebell Romanian Deadlift")]
		KettlebellRomanianDeadlift,

		[Description("Kettlebell Seated Press")]
		KettlebellSeatedPress,

		[Description("Kettlebell Seesaw Press")]
		KettlebellSeesawPress,

		[Description("Kettlebell Sots Press")]
		KettlebellSotsPress,

		[Description("Kettlebell Sumo High Pull")]
		KettlebellSumoHighPull,

		[Description("Kettlebell Thruster")]
		KettlebellThruster,

		[Description("Kickboxing")]
		Kickboxing,

		[Description("Kipping Muscle-Up")]
		KippingMuscleUp,

		[Description("Kipping Pull-Up")]
		KippingPullUp,

		[Description("Kirk Shrugs")]
		KirkShrugs,

		[Description("Knee Hug Sit-Up")]
		KneeHugSitUp,

		[Description("Knee Plank with Straight Arm Extension")]
		KneePlankwithStraightArmExtension,

		[Description("Knee Side Plank")]
		KneeSidePlank,

		[Description("Knee Tuck")]
		KneeTuck,

		[Description("Kneel Stand Jump")]
		KneelStandJump,

		[Description("Kneeling Cable Triceps Extension")]
		KneelingCableTricepsExtension,

		[Description("Kneeling Clap Push-Up")]
		KneelingClapPushUp,

		[Description("Kneeling Good Morning")]
		KneelingGoodMorning,

		[Description("Kneeling One-Arm Dumbbell Press")]
		KneelingOneArmDumbbellPress,

		[Description("Kneeling Push-Up")]
		KneelingPushUp,

		[Description("Knees-To-Elbows")]
		KneesToElbows,

		[Description("Krav Maga")]
		KravMaga,

		[Description("Kripalu Yoga")]
		KripaluYoga,

		[Description("Kroc Rows")]
		KrocRows,

		[Description("Kundalini Yoga")]
		KundaliniYoga,

		[Description("Kung Fu")]
		KungFu,

		[Description("L-Sit")]
		LSit,

		[Description("L-Sit Chin-Up")]
		LSitChinUp,

		[Description("L-Sit Pull-Up")]
		LSitPullUp,

		[Description("Lacrosse")]
		Lacrosse,

		[Description("Ladder Drills")]
		LadderDrills,

		[Description("Lake Canoeing")]
		LakeCanoeing,

		[Description("Lake Kayaking")]
		LakeKayaking,

		[Description("Landmines")]
		Landmines,

		[Description("Lat Pulldown")]
		LatPulldown,

		[Description("Lateral Bounds")]
		LateralBounds,

		[Description("Lateral Box Hop")]
		LateralBoxHop,

		[Description("Lateral Explosive Jump")]
		LateralExplosiveJump,

		[Description("Lateral Hurdle Jumps")]
		LateralHurdleJumps,

		[Description("Lateral Lunges")]
		LateralLunges,

		[Description("Lateral Raise - With Bands")]
		LateralRaiseWithBands,

		[Description("Lateral Step Up")]
		LateralStepUp,

		[Description("Lateral Walk")]
		LateralWalk,

		[Description("Latin Dancing")]
		LatinDancing,

		[Description("Leg Climb Crunch")]
		LegClimbCrunch,

		[Description("Leg Extensions")]
		LegExtensions,

		[Description("Leg Press")]
		LegPress,

		[Description("Leg Raise Progression")]
		LegRaiseProgression,

		[Description("Leg Swing")]
		LegSwing,

		[Description("Let Me Ins")]
		LetMeIns,

		[Description("Lever Handstand Push-Up")]
		LeverHandstandPushUp,

		[Description("Lever Push-Up")]
		LeverPushUp,

		[Description("Light Walking (secondary e.g. commute, on the job, etc)")]
		LightWalkingsecondaryegcommuteonthejobetc,

		[Description("Lindy Hopping")]
		LindyHopping,

		[Description("Log Clean and Press")]
		LogCleanandPress,

		[Description("Long Cycle")]
		LongCycle,

		[Description("Long Jumps")]
		LongJumps,

		[Description("Long-Lever Plank")]
		LongLeverPlank,

		[Description("Long-Lever Push-Up Hold")]
		LongLeverPushUpHold,

		[Description("Low Cable Triceps Extension")]
		LowCableTricepsExtension,

		[Description("Lying Arm Crossover")]
		LyingArmCrossover,

		[Description("Lying Barbell Triceps Extension")]
		LyingBarbellTricepsExtension,

		[Description("Lying Cambered Barbell Row")]
		LyingCamberedBarbellRow,

		[Description("Lying Close-Grip Barbell Triceps Extension Behind The Head")]
		LyingCloseGripBarbellTricepsExtensionBehindTheHead,

		[Description("Lying Close-Grip Barbell Triceps Press To Chin")]
		LyingCloseGripBarbellTricepsPressToChin,

		[Description("Lying Dumbbell Hamstring Curl")]
		LyingDumbbellHamstringCurl,

		[Description("Lying Dumbbell Tricep Extension")]
		LyingDumbbellTricepExtension,

		[Description("Lying Hamstring Stretch")]
		LyingHamstringStretch,

		[Description("Lying Leg Curls")]
		LyingLegCurls,

		[Description("Lying Rear Delt Raise")]
		LyingRearDeltRaise,

		[Description("Lying Triceps Press")]
		LyingTricepsPress,

		[Description("Machine Ab Crunch")]
		MachineAbCrunch,

		[Description("Machine Back Extension")]
		MachineBackExtension,

		[Description("Machine Bench Press")]
		MachineBenchPress,

		[Description("Machine Bicep Curls")]
		MachineBicepCurls,

		[Description("Machine Calf Extension")]
		MachineCalfExtension,

		[Description("Machine Chest Fly (Pec Deck)")]
		MachineChestFlyPecDeck,

		[Description("Machine Chest Press")]
		MachineChestPress,

		[Description("Machine Dips")]
		MachineDips,

		[Description("Machine Hack Squat")]
		MachineHackSquat,

		[Description("Machine Incline Bench Press")]
		MachineInclineBenchPress,

		[Description("Machine Lateral Raise")]
		MachineLateralRaise,

		[Description("Machine MTS High Row")]
		MachineMTSHighRow,

		[Description("Machine Preacher Curls")]
		MachinePreacherCurls,

		[Description("Machine Pullover")]
		MachinePullover,

		[Description("Machine Seated Row")]
		MachineSeatedRow,

		[Description("Machine Shoulder (Military) Press")]
		MachineShoulderMilitaryPress,

		[Description("Machine Triceps Extension")]
		MachineTricepsExtension,

		[Description("Medicine Ball Chest Pass")]
		MedicineBallChestPass,

		[Description("Medicine Ball Jack Knife Sit-Up")]
		MedicineBallJackKnifeSitUp,

		[Description("Meditation")]
		Meditation,

		[Description("Melbourne Shuffle")]
		MelbourneShuffle,

		[Description("Middle Back Shrug")]
		MiddleBackShrug,

		[Description("Mixed Grip Chin")]
		MixedGripChin,

		[Description("Moksha Yoga")]
		MokshaYoga,

		[Description("Mountain Biking")]
		MountainBiking,

		[Description("Mountain Climbers")]
		MountainClimbers,

		[Description("Moving boxes")]
		Movingboxes,

		[Description("Muay Thai")]
		MuayThai,

		[Description("Muscle Clean")]
		MuscleClean,

		[Description("Muscle Snatch")]
		MuscleSnatch,

		[Description("Muscle-Up")]
		MuscleUp,

		[Description("Narrow Arm Push-Up")]
		NarrowArmPushUp,

		[Description("Neck Extension - Harness")]
		NeckExtensionHarness,

		[Description("Neck Extension - Machine")]
		NeckExtensionMachine,

		[Description("Neck Extension - Plates")]
		NeckExtensionPlates,

		[Description("Neck Flexion - Harness")]
		NeckFlexionHarness,

		[Description("Neck Flexion - Machine")]
		NeckFlexionMachine,

		[Description("Neck Flexion - Plates")]
		NeckFlexionPlates,

		[Description("Neck Lateral Flexion - Harness")]
		NeckLateralFlexionHarness,

		[Description("Neck Lateral Flexion - Machine")]
		NeckLateralFlexionMachine,

		[Description("Neck Lateral Flexion - Plates")]
		NeckLateralFlexionPlates,

		[Description("Negative Chin-Up")]
		NegativeChinUp,

		[Description("Negative Pull-Up")]
		NegativePullUp,

		[Description("Netball")]
		Netball,

		[Description("Ninja Jump Tucks")]
		NinjaJumpTucks,

		[Description("Ninjutsu")]
		Ninjutsu,

		[Description("Oblique Crunch")]
		ObliqueCrunch,

		[Description("Oblique V-Ups")]
		ObliqueVUps,

		[Description("Ocean Kayaking")]
		OceanKayaking,

		[Description("One Arm Chin-Up")]
		OneArmChinUp,

		[Description("One Arm Farmer's Walk")]
		OneArmFarmersWalk,

		[Description("One Arm Lat Pulldown")]
		OneArmLatPulldown,

		[Description("One Arm Pronated Dumbbell Triceps Extension")]
		OneArmPronatedDumbbellTricepsExtension,

		[Description("One Half One-Arm Handstand Push-Up")]
		OneHalfOneArmHandstandPushUp,

		[Description("One Half One-Arm Pull-Up")]
		OneHalfOneArmPullUp,

		[Description("One Half One-Arm Push-Up")]
		OneHalfOneArmPushUp,

		[Description("One Legged Push Up")]
		OneLeggedPushUp,

		[Description("One-Arm Band Floor Press to Sit-Up")]
		OneArmBandFloorPresstoSitUp,

		[Description("One-Arm Band Row")]
		OneArmBandRow,

		[Description("One-Arm Barbell Corner Row")]
		OneArmBarbellCornerRow,

		[Description("One-Arm Barbell Deadlift")]
		OneArmBarbellDeadlift,

		[Description("One-Arm Barbell Snatch")]
		OneArmBarbellSnatch,

		[Description("One-Arm Body Weight Inverted Row (One-Arm Let Me Ups)")]
		OneArmBodyWeightInvertedRowOneArmLetMeUps,

		[Description("One-Arm Bottoms-up Kettlebell Carry")]
		OneArmBottomsupKettlebellCarry,

		[Description("One-Arm Cable Chest Press")]
		OneArmCableChestPress,

		[Description("One-Arm Dumbbell Bench Press")]
		OneArmDumbbellBenchPress,

		[Description("One-Arm Dumbbell Deadlift")]
		OneArmDumbbellDeadlift,

		[Description("One-Arm Dumbbell Floor Press")]
		OneArmDumbbellFloorPress,

		[Description("One-Arm Dumbbell Row")]
		OneArmDumbbellRow,

		[Description("One-Arm Dumbbell Snatch")]
		OneArmDumbbellSnatch,

		[Description("One-Arm Face Pull")]
		OneArmFacePull,

		[Description("One-Arm Handstand Push-Up")]
		OneArmHandstandPushUp,

		[Description("One-Arm Incline Dumbbell Bench Press")]
		OneArmInclineDumbbellBenchPress,

		[Description("One-Arm Kettlebell Clean")]
		OneArmKettlebellClean,

		[Description("One-Arm Kettlebell Floor Press")]
		OneArmKettlebellFloorPress,

		[Description("One-Arm Kettlebell Jerk")]
		OneArmKettlebellJerk,

		[Description("One-Arm Kettlebell Rack Carry")]
		OneArmKettlebellRackCarry,

		[Description("One-Arm Kettlebell Snatch")]
		OneArmKettlebellSnatch,

		[Description("One-Arm Kettlebell Swing")]
		OneArmKettlebellSwing,

		[Description("One-Arm Let Me Ins")]
		OneArmLetMeIns,

		[Description("One-Arm Pull-Up")]
		OneArmPullUp,

		[Description("One-Arm Push-Up")]
		OneArmPushUp,

		[Description("One-Arm Triceps Push-Up")]
		OneArmTricepsPushUp,

		[Description("One-Leg Body Weight Glute Bridge")]
		OneLegBodyWeightGluteBridge,

		[Description("One-Leg Body Weight Romanian Deadlift")]
		OneLegBodyWeightRomanianDeadlift,

		[Description("One-Leg Press")]
		OneLegPress,

		[Description("One-Leg Romanian Deadlift")]
		OneLegRomanianDeadlift,

		[Description("One-Leg Romanian Deadlift to Skater Squat")]
		OneLegRomanianDeadlifttoSkaterSquat,

		[Description("One-leg Barbell Glute Bridge")]
		OnelegBarbellGluteBridge,

		[Description("Other Bodyweight")]
		OtherBodyweight,

		[Description("Other Cardio")]
		OtherCardio,

		[Description("Other Dancing")]
		OtherDancing,

		[Description("Other Weightlifting")]
		OtherWeightlifting,

		[Description("Overhead Barbell Squat")]
		OverheadBarbellSquat,

		[Description("Overhead Dumbbell Split Squat")]
		OverheadDumbbellSplitSquat,

		[Description("Overhead Dumbbell Squat")]
		OverheadDumbbellSquat,

		[Description("Paddleboarding")]
		Paddleboarding,

		[Description("Paintball")]
		Paintball,

		[Description("Pallof Press")]
		PallofPress,

		[Description("Palms-Down Barbell Wrist Curl Over A Bench")]
		PalmsDownBarbellWristCurlOverABench,

		[Description("Palms-Down Dumbbell Wrist Curl Over A Bench")]
		PalmsDownDumbbellWristCurlOverABench,

		[Description("Palms-Up Barbell Wrist Curl Over A Bench")]
		PalmsUpBarbellWristCurlOverABench,

		[Description("Palms-Up Dumbbell Wrist Curl Over A Bench")]
		PalmsUpDumbbellWristCurlOverABench,

		[Description("Parallel Grip L-Sit Pull-Up")]
		ParallelGripLSitPullUp,

		[Description("Parallel-Grip Pull-Up")]
		ParallelGripPullUp,

		[Description("Parkour/Freerunning")]
		ParkourFreerunning,

		[Description("Partial Straight Leg Raise")]
		PartialStraightLegRaise,

		[Description("Peekaboo Goblet Squat")]
		PeekabooGobletSquat,

		[Description("Pendlay Row")]
		PendlayRow,

		[Description("Pike Push-Up")]
		PikePushUp,

		[Description("Pilates")]
		Pilates,

		[Description("Ping Pong")]
		PingPong,

		[Description("Pistol (Kettlebell)")]
		PistolKettlebell,

		[Description("Plank")]
		Plank,

		[Description("Plank Climber")]
		PlankClimber,

		[Description("Plank Jacks")]
		PlankJacks,

		[Description("Plank Progression")]
		PlankProgression,

		[Description("Plank Reach")]
		PlankReach,

		[Description("Plank Up-Down")]
		PlankUpDown,

		[Description("Plank With Hip Extension")]
		PlankWithHipExtension,

		[Description("Plate Pinch")]
		PlatePinch,

		[Description("Pole Dancing")]
		PoleDancing,

		[Description("Popping & Locking")]
		PoppingLocking,

		[Description("Power Clean")]
		PowerClean,

		[Description("Power Clean and Jerk")]
		PowerCleanandJerk,

		[Description("Power Clean and Press")]
		PowerCleanandPress,

		[Description("Power Jerk")]
		PowerJerk,

		[Description("Power Snatch")]
		PowerSnatch,

		[Description("Preacher Curl")]
		PreacherCurl,

		[Description("Preacher Hammer Dumbbell Curl")]
		PreacherHammerDumbbellCurl,

		[Description("Prone Horizontal Abduction Off Table")]
		ProneHorizontalAbductionOffTable,

		[Description("Prone One-Arm Trap Raise")]
		ProneOneArmTrapRaise,

		[Description("Pull-Up")]
		PullUp,

		[Description("Pull-Up Progression")]
		PullUpProgression,

		[Description("Pulse Up - Knees Out")]
		PulseUpKneesOut,

		[Description("Pulse Up - Legs Straight")]
		PulseUpLegsStraight,

		[Description("Push Press")]
		PushPress,

		[Description("Push-Up")]
		PushUp,

		[Description("Push-Up Hold")]
		PushUpHold,

		[Description("Push-Up Ladder")]
		PushUpLadder,

		[Description("Push-Up Plus")]
		PushUpPlus,

		[Description("Push-Up Progression")]
		PushUpProgression,

		[Description("Qigong")]
		Qigong,

		[Description("Quadruped Donkey Kick")]
		QuadrupedDonkeyKick,

		[Description("Quadruped Dumbbell Row")]
		QuadrupedDumbbellRow,

		[Description("Quadruped Hip Extension")]
		QuadrupedHipExtension,

		[Description("Quarter Jump Squat")]
		QuarterJumpSquat,

		[Description("Rack Bench Press")]
		RackBenchPress,

		[Description("Rack Deadlift")]
		RackDeadlift,

		[Description("Rack Squat")]
		RackSquat,

		[Description("Racquetball")]
		Racquetball,

		[Description("Rainbow Extension")]
		RainbowExtension,

		[Description("Raptor Squat")]
		RaptorSquat,

		[Description("Rear Delt Fly")]
		RearDeltFly,

		[Description("Rear Leg Raises")]
		RearLegRaises,

		[Description("Recreational Swimming")]
		RecreationalSwimming,

		[Description("Renegade Push-Up")]
		RenegadePushUp,

		[Description("Renegade Row")]
		RenegadeRow,

		[Description("Reptile (Spider) Push-Up")]
		ReptileSpiderPushUp,

		[Description("Restorative Yoga")]
		RestorativeYoga,

		[Description("Reverse Barbell Curl")]
		ReverseBarbellCurl,

		[Description("Reverse Barbell Preacher Curls")]
		ReverseBarbellPreacherCurls,

		[Description("Reverse Cable Curl")]
		ReverseCableCurl,

		[Description("Reverse Crunch")]
		ReverseCrunch,

		[Description("Reverse Elbow Pushups")]
		ReverseElbowPushups,

		[Description("Reverse Flyes")]
		ReverseFlyes,

		[Description("Reverse Grip Bent-Over Rows")]
		ReverseGripBentOverRows,

		[Description("Reverse Grip Clean and Press")]
		ReverseGripCleanandPress,

		[Description("Reverse Grip Triceps Pushdown")]
		ReverseGripTricepsPushdown,

		[Description("Reverse Hyperextension")]
		ReverseHyperextension,

		[Description("Reverse Pushups")]
		ReversePushups,

		[Description("Reverse Triceps Bench Press")]
		ReverseTricepsBenchPress,

		[Description("Ring Dip")]
		RingDip,

		[Description("Ring Muscle-Up")]
		RingMuscleUp,

		[Description("Ring Pull-Up")]
		RingPullUp,

		[Description("River Kayaking")]
		RiverKayaking,

		[Description("Rock Climbing")]
		RockClimbing,

		[Description("Rock Climbing (time only)")]
		RockClimbingtimeonly,

		[Description("Rocking Plank")]
		RockingPlank,

		[Description("Rocking Standing Calf Raise")]
		RockingStandingCalfRaise,

		[Description("Roller Derby")]
		RollerDerby,

		[Description("Roller Skating")]
		RollerSkating,

		[Description("Rolling")]
		Rolling,

		[Description("Romanian Band Deadlift")]
		RomanianBandDeadlift,

		[Description("Romanian Deadlift")]
		RomanianDeadlift,

		[Description("Romanian Dumbbell Deadlift")]
		RomanianDumbbellDeadlift,

		[Description("Rope Climb")]
		RopeClimb,

		[Description("Rotary Torso Machine")]
		RotaryTorsoMachine,

		[Description("Rowing")]
		Rowing,

		[Description("Rowing (machine)")]
		Rowingmachine,

		[Description("Rugby")]
		Rugby,

		[Description("Running")]
		Running,

		[Description("Running (Intervals/Sprints)")]
		RunningIntervalsSprints,

		[Description("Running (treadmill)")]
		Runningtreadmill,

		[Description("Running Stairs")]
		RunningStairs,

		[Description("Russian Twist")]
		RussianTwist,

		[Description("SCA Heavy Combat")]
		SCAHeavyCombat,

		[Description("Safety Squats")]
		SafetySquats,

		[Description("Sailing")]
		Sailing,

		[Description("Salsa")]
		Salsa,

		[Description("Sandbag Carry")]
		SandbagCarry,

		[Description("Sandbag Squat")]
		SandbagSquat,

		[Description("Savate")]
		Savate,

		[Description("Scapular Push-Up")]
		ScapularPushUp,

		[Description("Scapular Wall Slide")]
		ScapularWallSlide,

		[Description("Scarecrow Clean")]
		ScarecrowClean,

		[Description("Scarecrow Snatch")]
		ScarecrowSnatch,

		[Description("Scissor Crunch")]
		ScissorCrunch,

		[Description("Scissor Kicks")]
		ScissorKicks,

		[Description("Scissor Tap")]
		ScissorTap,

		[Description("Scissors with Hold (Beach Scissors)")]
		ScissorswithHoldBeachScissors,

		[Description("Scuba Diving")]
		ScubaDiving,

		[Description("Seated Band Abduction")]
		SeatedBandAbduction,

		[Description("Seated Band Row")]
		SeatedBandRow,

		[Description("Seated Barbell Military Press")]
		SeatedBarbellMilitaryPress,

		[Description("Seated Barbell Press Behind Neck")]
		SeatedBarbellPressBehindNeck,

		[Description("Seated Barbell Shoulder Press")]
		SeatedBarbellShoulderPress,

		[Description("Seated Bent-Over 2-Arm Dumbbell Triceps Extension")]
		SeatedBentOverTwoArmDumbbellTricepsExtension,

		[Description("Seated Bent-Over Rear Delt Raise")]
		SeatedBentOverRearDeltRaise,

		[Description("Seated Cable Row")]
		SeatedCableRow,

		[Description("Seated Calf Raise")]
		SeatedCalfRaise,

		[Description("Seated Dumbbell Curl")]
		SeatedDumbbellCurl,

		[Description("Seated Dumbbell Inner Biceps Curl")]
		SeatedDumbbellInnerBicepsCurl,

		[Description("Seated Dumbbell Palms-Down Wrist Curl")]
		SeatedDumbbellPalmsDownWristCurl,

		[Description("Seated Dumbbell Palms-Up Wrist Curl")]
		SeatedDumbbellPalmsUpWristCurl,

		[Description("Seated Dumbbell Row")]
		SeatedDumbbellRow,

		[Description("Seated Dumbbell Shoulder Press")]
		SeatedDumbbellShoulderPress,

		[Description("Seated Dumbbell Side Lateral Raise")]
		SeatedDumbbellSideLateralRaise,

		[Description("Seated Front Deltoid Stretch")]
		SeatedFrontDeltoidStretch,

		[Description("Seated Glute Stretch")]
		SeatedGluteStretch,

		[Description("Seated Good Morning")]
		SeatedGoodMorning,

		[Description("Seated Hammer Dumbbell Curl")]
		SeatedHammerDumbbellCurl,

		[Description("Seated Hamstring Stretch")]
		SeatedHamstringStretch,

		[Description("Seated Knee Hug Crunch")]
		SeatedKneeHugCrunch,

		[Description("Seated Knee Tuck")]
		SeatedKneeTuck,

		[Description("Seated Leg Curl")]
		SeatedLegCurl,

		[Description("Seated Leg Extension Crunch")]
		SeatedLegExtensionCrunch,

		[Description("Seated Palm-Up Barbell Wrist Curl")]
		SeatedPalmUpBarbellWristCurl,

		[Description("Seated Palms-Down Barbell Wrist Curl")]
		SeatedPalmsDownBarbellWristCurl,

		[Description("Seated Side Lateral Raise")]
		SeatedSideLateralRaise,

		[Description("Seated Thoracic Twist")]
		SeatedThoracicTwist,

		[Description("Seated Triceps Press")]
		SeatedTricepsPress,

		[Description("Shake Weight")]
		ShakeWeight,

		[Description("Short Bridge")]
		ShortBridge,

		[Description("Shoulder Dislocation")]
		ShoulderDislocation,

		[Description("Shove Offs")]
		ShoveOffs,

		[Description("Shoveling snow")]
		Shovelingsnow,

		[Description("Shuai Jiao")]
		ShuaiJiao,

		[Description("Side Crunch")]
		SideCrunch,

		[Description("Side Lateral Raise")]
		SideLateralRaise,

		[Description("Side Lunges")]
		SideLunges,

		[Description("Side Lying Clam Shell")]
		SideLyingClamShell,

		[Description("Side Lying Hip Raise")]
		SideLyingHipRaise,

		[Description("Side Plank")]
		SidePlank,

		[Description("Side Plank Clam")]
		SidePlankClam,

		[Description("Side Plank Lifts")]
		SidePlankLifts,

		[Description("Side-Lying External Rotation")]
		SideLyingExternalRotation,

		[Description("Single Arm Kettlebell Clean and Press")]
		SingleArmKettlebellCleanandPress,

		[Description("Single Leg Glute Bridge With Straight Arms")]
		SingleLegGluteBridgeWithStraightArms,

		[Description("Single-Leg Plank")]
		SingleLegPlank,

		[Description("Sissy Squat")]
		SissySquat,

		[Description("Sit-Up")]
		SitUp,

		[Description("Sitting on my Butt")]
		SittingonmyButt,

		[Description("Sivananda Yoga")]
		SivanandaYoga,

		[Description("Skateboarding")]
		Skateboarding,

		[Description("Ski Machine")]
		SkiMachine,

		[Description("Skiing")]
		Skiing,

		[Description("Sled Pull")]
		SledPull,

		[Description("Sled Push")]
		SledPush,

		[Description("Sled Sprint")]
		SledSprint,

		[Description("Sledgehammer")]
		Sledgehammer,

		[Description("Slideboard")]
		Slideboard,

		[Description("Slideboard Bodysaw")]
		SlideboardBodysaw,

		[Description("Sliding Leg Curl")]
		SlidingLegCurl,

		[Description("Slosh Pipe Carry")]
		SloshPipeCarry,

		[Description("Smith Incline Shoulder Raise")]
		SmithInclineShoulderRaise,

		[Description("Smith Machine Bench Press")]
		SmithMachineBenchPress,

		[Description("Smith Machine Bent Over Row")]
		SmithMachineBentOverRow,

		[Description("Smith Machine Close-Grip Bench Press")]
		SmithMachineCloseGripBenchPress,

		[Description("Smith Machine Incline Bench Press")]
		SmithMachineInclineBenchPress,

		[Description("Smith Machine Overhead Shoulder Press")]
		SmithMachineOverheadShoulderPress,

		[Description("Smith Machine Reverse Calf Raises")]
		SmithMachineReverseCalfRaises,

		[Description("Smith Machine Shrug")]
		SmithMachineShrug,

		[Description("Smith Machine Squat")]
		SmithMachineSquat,

		[Description("Smith Machine Upright Row")]
		SmithMachineUprightRow,

		[Description("Snatch")]
		Snatch,

		[Description("Snatch Balance")]
		SnatchBalance,

		[Description("Snatch Grip Behind the Neck Press")]
		SnatchGripBehindtheNeckPress,

		[Description("Snatch Pull")]
		SnatchPull,

		[Description("Snatch-Grip Deadlift")]
		SnatchGripDeadlift,

		[Description("Snowboarding")]
		Snowboarding,

		[Description("Snowshoeing")]
		Snowshoeing,

		[Description("Softball")]
		Softball,

		[Description("Spartan Race")]
		SpartanRace,

		[Description("Speed Bag")]
		SpeedBag,

		[Description("Spider Curl")]
		SpiderCurl,

		[Description("Spinning")]
		Spinning,

		[Description("Split Clean and Jerk")]
		SplitCleanandJerk,

		[Description("Split Jerk")]
		SplitJerk,

		[Description("Split Jump Squat (Iron Mikes)")]
		SplitJumpSquatIronMikes,

		[Description("Split Snatch")]
		SplitSnatch,

		[Description("Sprinter's Crunch")]
		SprintersCrunch,

		[Description("Squash")]
		Squash,

		[Description("Squat Clean")]
		SquatClean,

		[Description("Squat Jerk")]
		SquatJerk,

		[Description("Squat Lockout")]
		SquatLockout,

		[Description("Squat Progression")]
		SquatProgression,

		[Description("Squat Stretch")]
		SquatStretch,

		[Description("Squat to Stand with Overhead Reach")]
		SquattoStandwithOverheadReach,

		[Description("Stability Ball Jack Knife Sit-Up")]
		StabilityBallJackKnifeSitUp,

		[Description("Stability Ball Push-Up")]
		StabilityBallPushUp,

		[Description("Staggered Push-Up")]
		StaggeredPushUp,

		[Description("Stair Machine")]
		StairMachine,

		[Description("Stand-To-Stand Bridge")]
		StandToStandBridge,

		[Description("Stand-Up Paddleboarding")]
		StandUpPaddleboarding,

		[Description("Standing Band Shoulder Press")]
		StandingBandShoulderPress,

		[Description("Standing Band Shoulder Press to Lateral Raise")]
		StandingBandShoulderPresstoLateralRaise,

		[Description("Standing Barbell Calf Raise")]
		StandingBarbellCalfRaise,

		[Description("Standing Barbell Press Behind Neck")]
		StandingBarbellPressBehindNeck,

		[Description("Standing Barbell Shoulder Press (OHP)")]
		StandingBarbellShoulderPressOHP,

		[Description("Standing Biceps Cable Curl")]
		StandingBicepsCableCurl,

		[Description("Standing Bird-Dog")]
		StandingBirdDog,

		[Description("Standing Calf Raise")]
		StandingCalfRaise,

		[Description("Standing Dumbbell Calf Raise")]
		StandingDumbbellCalfRaise,

		[Description("Standing Dumbbell Push Press")]
		StandingDumbbellPushPress,

		[Description("Standing Dumbbell Reverse Curl")]
		StandingDumbbellReverseCurl,

		[Description("Standing Dumbbell Shoulder Press")]
		StandingDumbbellShoulderPress,

		[Description("Standing Dumbbell Straight-Arm Front Delt Raise Above Head")]
		StandingDumbbellStraightArmFrontDeltRaiseAboveHead,

		[Description("Standing Dumbbell Triceps Extension")]
		StandingDumbbellTricepsExtension,

		[Description("Standing Dumbbell Upright Row")]
		StandingDumbbellUprightRow,

		[Description("Standing Front Barbell Raise Over Head")]
		StandingFrontBarbellRaiseOverHead,

		[Description("Standing Hip Flexors Stretch")]
		StandingHipFlexorsStretch,

		[Description("Standing Inner-Biceps Curl")]
		StandingInnerBicepsCurl,

		[Description("Standing Leg Curl")]
		StandingLegCurl,

		[Description("Standing Low-Pulley Deltoid Raise")]
		StandingLowPulleyDeltoidRaise,

		[Description("Standing Military Press")]
		StandingMilitaryPress,

		[Description("Standing One-Arm Biceps Cable Curl")]
		StandingOneArmBicepsCableCurl,

		[Description("Standing One-Arm Dumbbell Curl Over Incline Bench")]
		StandingOneArmDumbbellCurlOverInclineBench,

		[Description("Standing One-Arm Dumbbell Push Press")]
		StandingOneArmDumbbellPushPress,

		[Description("Standing One-Arm Dumbbell Shoulder Press")]
		StandingOneArmDumbbellShoulderPress,

		[Description("Standing One-Arm Dumbbell Triceps Extension")]
		StandingOneArmDumbbellTricepsExtension,

		[Description("Standing One-Arm Landmine Press")]
		StandingOneArmLandminePress,

		[Description("Standing Overhead Barbell Triceps Extension")]
		StandingOverheadBarbellTricepsExtension,

		[Description("Standing Palms-In Dumbbell Shoulder Press")]
		StandingPalmsInDumbbellShoulderPress,

		[Description("Standing Row")]
		StandingRow,

		[Description("Standing Shoulder Press Lockout")]
		StandingShoulderPressLockout,

		[Description("Standing Zottman Dumbbell Curls")]
		StandingZottmanDumbbellCurls,

		[Description("Standing one-arm Cable Rows")]
		StandingonearmCableRows,

		[Description("Star Jumps")]
		StarJumps,

		[Description("Start Bodyweight Dynamic Warmup")]
		StartBodyweightDynamicWarmup,

		[Description("Static Wall Sit")]
		StaticWallSit,

		[Description("Static Wall Sit - One Leg Out")]
		StaticWallSitOneLegOut,

		[Description("Step Class")]
		StepClass,

		[Description("Step Up")]
		StepUp,

		[Description("Step Up High Knee")]
		StepUpHighKnee,

		[Description("Stick Up")]
		StickUp,

		[Description("Stiff Leg Barbell Good Morning")]
		StiffLegBarbellGoodMorning,

		[Description("Stiff-Legged Barbell Deadlift")]
		StiffLeggedBarbellDeadlift,

		[Description("Stiff-Legged Dumbbell Deadlift")]
		StiffLeggedDumbbellDeadlift,

		[Description("Stir The Pot")]
		StirThePot,

		[Description("Stone Carry")]
		StoneCarry,

		[Description("Straddle Planche")]
		StraddlePlanche,

		[Description("Straight Arm Pulldown")]
		StraightArmPulldown,

		[Description("Straight Bridge")]
		StraightBridge,

		[Description("Street Hockey")]
		StreetHockey,

		[Description("Strength Class")]
		StrengthClass,

		[Description("Stretching")]
		Stretching,

		[Description("Sumo Deadlift")]
		SumoDeadlift,

		[Description("Super Bird Dog")]
		SuperBirdDog,

		[Description("Superman")]
		Superman,

		[Description("Superman Hold")]
		SupermanHold,

		[Description("Superman Reach")]
		SupermanReach,

		[Description("Surf Getup")]
		SurfGetup,

		[Description("Surfing")]
		Surfing,

		[Description("Suspension Trainer Biceps Clutch")]
		SuspensionTrainerBicepsClutch,

		[Description("Suspension Trainer Biceps Curl")]
		SuspensionTrainerBicepsCurl,

		[Description("Suspension Trainer Crossing Balance Lunge")]
		SuspensionTrainerCrossingBalanceLunge,

		[Description("Suspension Trainer Crunch")]
		SuspensionTrainerCrunch,

		[Description("Suspension Trainer Fallouts")]
		SuspensionTrainerFallouts,

		[Description("Suspension Trainer Flutter")]
		SuspensionTrainerFlutter,

		[Description("Suspension Trainer Inverted Rows")]
		SuspensionTrainerInvertedRows,

		[Description("Suspension Trainer Push-ups")]
		SuspensionTrainerPushups,

		[Description("Suspension Trainer Ys")]
		SuspensionTrainerYs,

		[Description("Swimming")]
		Swimming,

		[Description("Swing Dancing")]
		SwingDancing,

		[Description("T Push-Up")]
		TPushUp,

		[Description("T-Bar Row")]
		TBarRow,

		[Description("Taekwondo")]
		Taekwondo,

		[Description("Tai Chi")]
		TaiChi,

		[Description("Tall Kneeling Anti-Rotation Chop")]
		TallKneelingAntiRotationChop,

		[Description("Tall Kneeling Cable Lift")]
		TallKneelingCableLift,

		[Description("Tall Kneeling Medicine Ball Slams")]
		TallKneelingMedicineBallSlams,

		[Description("Tango")]
		Tango,

		[Description("Tap Dancing")]
		TapDancing,

		[Description("Tectonic")]
		Tectonic,

		[Description("Tennis")]
		Tennis,

		[Description("Thrusters")]
		Thrusters,

		[Description("Tire Flip")]
		TireFlip,

		[Description("Toe Touches")]
		ToeTouches,

		[Description("Toes-To-Bar")]
		ToesToBar,

		[Description("Tough Mudder")]
		ToughMudder,

		[Description("Trail Running")]
		TrailRunning,

		[Description("Trampoline")]
		Trampoline,

		[Description("Trap Bar Deadlift")]
		TrapBarDeadlift,

		[Description("Tricep Dumbbell Kickback")]
		TricepDumbbellKickback,

		[Description("Triceps Pushdown")]
		TricepsPushdown,

		[Description("Triceps Pushdown - Rope Attachment")]
		TricepsPushdownRopeAttachment,

		[Description("Triceps Pushdown - V-Bar Attachment")]
		TricepsPushdownVBarAttachment,

		[Description("Tuck Planche")]
		TuckPlanche,

		[Description("Tuck Planche Push-Up")]
		TuckPlanchePushUp,

		[Description("Turkish Get-Up (barbell)")]
		TurkishGetUpbarbell,

		[Description("Turkish Get-Up (dumbbell)")]
		TurkishGetUpdumbbell,

		[Description("Turkish Get-Up (kettlebell)")]
		TurkishGetUpkettlebell,

		[Description("Twist of Faith")]
		TwistofFaith,

		[Description("Two-Arm Bottoms-up Kettlebell Carry")]
		TwoArmBottomsupKettlebellCarry,

		[Description("Two-Arm Kettlebell Swing")]
		TwoArmKettlebellSwing,

		[Description("Ultimate Frisbee")]
		UltimateFrisbee,

		[Description("Uneven Handstand Push-Up")]
		UnevenHandstandPushUp,

		[Description("Uneven Pull-Up")]
		UnevenPullUp,

		[Description("Uneven Push-Up")]
		UnevenPushUp,

		[Description("Up Down")]
		UpDown,

		[Description("Upright Barbell Row")]
		UprightBarbellRow,

		[Description("Upright Cable Row")]
		UprightCableRow,

		[Description("V-Bar Pull-Up")]
		VBarPullUp,

		[Description("V-Bar Pulldown")]
		VBarPulldown,

		[Description("V-Squat Machine")]
		VSquatMachine,

		[Description("V-Up")]
		VUp,

		[Description("Vertical Jumps")]
		VerticalJumps,

		[Description("Vertical Leg Crunch")]
		VerticalLegCrunch,

		[Description("Vertical Pull")]
		VerticalPull,

		[Description("Video Game Dancing")]
		VideoGameDancing,

		[Description("Viet Vo Dao")]
		VietVoDao,

		[Description("Viking Press")]
		VikingPress,

		[Description("Vinyasa")]
		Vinyasa,

		[Description("Waiter Walk")]
		WaiterWalk,

		[Description("Wakeboarding")]
		Wakeboarding,

		[Description("Walked up the stairs (in lieu of the elevator)")]
		Walkedupthestairsinlieuoftheelevator,

		[Description("Walking")]
		Walking,

		[Description("Walking (treadmill)")]
		Walkingtreadmill,

		[Description("Walking Barbell Lunges")]
		WalkingBarbellLunges,

		[Description("Walking Dumbbell Lunges")]
		WalkingDumbbellLunges,

		[Description("Walking Lunge")]
		WalkingLunge,

		[Description("Walkout")]
		Walkout,

		[Description("Walkout Push-Up")]
		WalkoutPushUp,

		[Description("Wall Ball")]
		WallBall,

		[Description("Wall Handstand")]
		WallHandstand,

		[Description("Wall Headstand")]
		WallHeadstand,

		[Description("Wall Push-Up")]
		WallPushUp,

		[Description("Wall Walking Bridge (Down)")]
		WallWalkingBridgeDown,

		[Description("Wall Walking Bridge (Up)")]
		WallWalkingBridgeUp,

		[Description("Warrior Dash")]
		WarriorDash,

		[Description("Water Polo")]
		WaterPolo,

		[Description("Water Skiing")]
		WaterSkiing,

		[Description("Weighted Ball Hyperextension")]
		WeightedBallHyperextension,

		[Description("Weighted Crunch")]
		WeightedCrunch,

		[Description("Weighted Dead Bug")]
		WeightedDeadBug,

		[Description("Weighted Decline Crunch")]
		WeightedDeclineCrunch,

		[Description("Weighted Decline Sit-Up")]
		WeightedDeclineSitUp,

		[Description("Weighted Exercise Ball Crunch")]
		WeightedExerciseBallCrunch,

		[Description("Weighted Glute Hamstring Raise")]
		WeightedGluteHamstringRaise,

		[Description("Weighted Hanging Leg Raise")]
		WeightedHangingLegRaise,

		[Description("Weighted Hyperextension")]
		WeightedHyperextension,

		[Description("Weighted Inverted Row (Let Me Ups)")]
		WeightedInvertedRowLetMeUps,

		[Description("Weighted Lying Leg Raise")]
		WeightedLyingLegRaise,

		[Description("Weighted Narrow Arm Push-Up")]
		WeightedNarrowArmPushUp,

		[Description("Weighted Oblique Crunch")]
		WeightedObliqueCrunch,

		[Description("Weighted One-Leg Squat")]
		WeightedOneLegSquat,

		[Description("Weighted Reverse Crunch")]
		WeightedReverseCrunch,

		[Description("Weighted Reverse Hyperextension")]
		WeightedReverseHyperextension,

		[Description("Weighted Ring L-sit")]
		WeightedRingLsit,

		[Description("Weighted Ring Push-Up")]
		WeightedRingPushUp,

		[Description("Weighted Russian Twist")]
		WeightedRussianTwist,

		[Description("Weighted Sit-Up")]
		WeightedSitUp,

		[Description("Weighted Stability Squat")]
		WeightedStabilitySquat,

		[Description("Weighted Wall Squat")]
		WeightedWallSquat,

		[Description("Weighted Wide Arm Push-Up")]
		WeightedWideArmPushUp,

		[Description("Wheelchair Racing")]
		WheelchairRacing,

		[Description("Wide Arm Push-Up")]
		WideArmPushUp,

		[Description("Wide Leg Sit-Up")]
		WideLegSitUp,

		[Description("Wide-Grip Barbell Bench Press")]
		WideGripBarbellBenchPress,

		[Description("Wide-Grip Chin-Up")]
		WideGripChinUp,

		[Description("Wide-Grip Decline Barbell Bench Press")]
		WideGripDeclineBarbellBenchPress,

		[Description("Wide-Grip Decline Barbell Pullover")]
		WideGripDeclineBarbellPullover,

		[Description("Wide-Grip Lat Pulldown")]
		WideGripLatPulldown,

		[Description("Wide-Grip Pull-Up")]
		WideGripPullUp,

		[Description("Wide-Grip Pulldown Behind The Neck")]
		WideGripPulldownBehindTheNeck,

		[Description("Wide-Grip Standing Barbell Curl")]
		WideGripStandingBarbellCurl,

		[Description("Wide-Stance Anti-Rotation Chop")]
		WideStanceAntiRotationChop,

		[Description("Windmill")]
		Windmill,

		[Description("Wing Chun")]
		WingChun,

		[Description("Woodchoppers")]
		Woodchoppers,

		[Description("Wrestling")]
		Wrestling,

		[Description("X Band Walk")]
		XBandWalk,

		[Description("YTI Raises")]
		YTIRaises,

		[Description("Yard Work")]
		YardWork,

		[Description("Yates Row")]
		YatesRow,

		[Description("Yin Yoga")]
		YinYoga,

		[Description("Yoga Push-Up")]
		YogaPushUp,

		[Description("Yoke Walk")]
		YokeWalk,

		[Description("Zercher Deadlift")]
		ZercherDeadlift,

		[Description("Zercher Good Morning")]
		ZercherGoodMorning,

		[Description("Zercher Squat")]
		ZercherSquat,

		[Description("Zumba")]
		Zumba
	}
}

