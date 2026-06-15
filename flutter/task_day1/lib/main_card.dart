import 'package:flutter/material.dart';

class MainCard extends StatelessWidget {
  const MainCard({super.key});

  @override
  Widget build(BuildContext context) {
    return const Card(
      color: Colors.white,
      elevation: 2,
      child: Padding(
        padding: EdgeInsets.symmetric(horizontal: 24, vertical: 32),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Row(
                  children: [
                    Text(
                      "14 / 20",
                      style: TextStyle(
                        fontSize: 42,
                        fontWeight: FontWeight.bold,
                        letterSpacing: 1,
                      ),
                    ),
                    SizedBox(width: 12),
                    Icon(
                      Icons.arrow_upward,
                      color: Colors.green,
                      size: 34,
                    ),
                  ],
                ),
                SizedBox(height: 12),
                Row(
                  children: [
                    Text(
                      "Tasks Optimized",
                      style: TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.w500,
                        color: Colors.black87,
                      ),
                    ),
                    SizedBox(width: 8),
                    Icon(
                      Icons.check_circle,
                      color: Colors.green,
                      size: 22,
                    ),
                  ],
                ),
              ],
            ),
            Stack(
              alignment: Alignment.center,
              children: [
                SizedBox(
                  width: 85,
                  height: 85,
                  child: CircularProgressIndicator(
                    value: 0.70,
                    strokeWidth: 9,
                    backgroundColor: Color(0xFFE2E8F0),
                    color: Color(0xFF4A6984),
                  ),
                ),
                Text(
                  "70%",
                  style: TextStyle(
                    fontSize: 20,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
