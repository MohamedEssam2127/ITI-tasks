import 'package:flutter/material.dart';
import 'course_badge.dart';

class BadgeList extends StatelessWidget {
  const BadgeList({super.key});

  @override
  Widget build(BuildContext context) {
    return const SingleChildScrollView(
      scrollDirection: Axis.horizontal,
      child: Row(
        children: [
          CourseBadge(
            text: 'All Tasks',
            textColor: Color(0xFF4A6984),
            backgroundColor: Color(0xFFE6F0FA),
          ),
          SizedBox(width: 10),
          CourseBadge(
            text: 'In Progress',
            textColor: Color(0xFF8A6D3B),
            backgroundColor: Color(0xFFFCF8E3),
          ),
          SizedBox(width: 10),
          CourseBadge(
            text: 'Completed',
            textColor: Color(0xFF3C763D),
            backgroundColor: Color(0xFFDFF0D8),
          ),
          SizedBox(width: 10),
          CourseBadge(
            text: 'Archived',
            textColor: Color(0xFF7B1FA2),
            backgroundColor: Color(0xFFF3E5F5),
          ),
        ],
      ),
    );
  }
}
