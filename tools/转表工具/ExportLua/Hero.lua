return {
	[1] = {
		heroId = 1,
		name = "英雄法师",
		rare = 11,
		type = 1,
		defaultStar = 1,
		isOpen = true,
		attributes = {
			attack = {
				physical = 20,
				magic = 100,
				canCrit = true,
				hitRate = 0.9,
				ult = {
					[1] = {
						name = "CoupDeGrace",
						params = {
							[1] = "circle",
							[2] = 1,
							[3] = 0,
							[4] = true,
						},
						cd = 5,
					},
				},
			},
			defence = {
				physical = 10,
				magic = 60,
			},
			hp = 200,
			modelSize = {
				[1] = 4,
				[2] = 5,
				[3] = 10.5,
			},
			petPhrase = "I will kill you!",
		},
	},
	[2] = {
		heroId = 2,
		name = "英雄战士",
		rare = 11,
		type = 2,
		defaultStar = 1,
		isOpen = true,
		attributes = nil,
	},
	[3] = {
		heroId = 3,
		name = "英雄牧师",
		rare = 11,
		type = 3,
		defaultStar = 1,
		isOpen = false,
		attributes = nil,
	},
	[4] = {
		heroId = 4,
		name = "英雄勇士",
		rare = 11,
		type = 4,
		defaultStar = 1,
		isOpen = false,
		attributes = {
			attack = {
				physical = 140,
				magic = 0,
				canCrit = true,
				hitRate = 0.9,
				ult = {
					[1] = {
						name = "CoupDeGrace",
						params = {
							[1] = "sector",
							[2] = 150,
							[3] = 0,
							[4] = true,
						},
						cd = 5,
					},
				},
			},
			defence = {
				physical = 40,
				magic = 0,
			},
			hp = 150,
			modelSize = {
				[1] = 3.5,
				[2] = 4,
				[3] = 8,
			},
			petPhrase = "Death to all who oppose me!",
		},
	},
}
