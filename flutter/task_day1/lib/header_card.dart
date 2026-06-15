import 'package:flutter/material.dart';

class HeaderCard extends StatelessWidget {
  const HeaderCard({super.key});

  @override
  Widget build(BuildContext context) {
    return const Card(
      color: Colors.white,
      child: Padding(
        padding: EdgeInsets.symmetric(horizontal: 20, vertical: 24),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  "OPERATOR ASSIGNMENT",
                  style: TextStyle(
                    fontSize: 14,
                    color: Colors.grey,
                    fontWeight: FontWeight.w500,
                    letterSpacing: 0.5,
                  ),
                ),
                SizedBox(height: 6),
                Text(
                  "SENIOR ENGINEER",
                  style: TextStyle(
                    fontSize: 24,
                    fontWeight: FontWeight.bold,
                    color: Colors.black,
                  ),
                ),
              ],
            ),
            CircleAvatar(
              radius: 32,
              backgroundColor: Color(0xFFE2E8F0),
              child: Icon(Icons.person, color: Color(0xFF64748B), size: 36),
            ),
          ],
        ),
      ),
    );
  }
}
