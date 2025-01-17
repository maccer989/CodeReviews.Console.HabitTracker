﻿interface IHabit
{

    public string ConnectionString { get; }
    public string HabitName { get; }
    public string HabitTable { get; }
    public string HabitUnit { get; }

    bool Insert(string time, int value);
	bool Update(string time, int value);
	void Delete(string index);
	void Read();
	void DeleteAll();

}