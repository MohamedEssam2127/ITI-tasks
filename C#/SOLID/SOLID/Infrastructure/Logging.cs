using System;

namespace OrderSystem.Infrastructure;

public class FileOrderLogger  { public void Log(string msg) => Console.WriteLine($"[LOG] {msg}"); }
