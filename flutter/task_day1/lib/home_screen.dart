import 'package:flutter/material.dart';
import 'header_card.dart';
import 'badge_list.dart';
import 'main_card.dart';
import 'critical_directives_section.dart';
import 'start_lesson_button.dart';

class HomeScreen extends StatelessWidget {
  const HomeScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color(0xFFF8F9FA),
      appBar: AppBar(
        title: const Text(
          "Task Analytics Workspace",
          style: TextStyle(fontWeight: FontWeight.bold, fontSize: 22),
        ),
        centerTitle: true,
      ),
      body: const SafeArea(
        child: SingleChildScrollView(
          padding: EdgeInsets.symmetric(horizontal: 18, vertical: 16),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              HeaderCard(),
              SizedBox(height: 24),
              BadgeList(),
              SizedBox(height: 24),
              MainCard(),
              CriticalDirectivesSection(),
              StartLessonButton()
            ],
          ),
        ),
      ),
    );
  }
}
