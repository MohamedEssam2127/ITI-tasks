import 'package:flutter/material.dart';

class HeaderCard extends StatelessWidget {
   HeaderCard({super.key,  required this.text });

  String text ;
  @override
  Widget build(BuildContext context) {
    final colorScheme = Theme.of(context).colorScheme;
    return  Card(
      color: colorScheme.primary ,
      child:  Padding(
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
                    color: colorScheme.onPrimary,
                    fontWeight: FontWeight.w500,
                    letterSpacing: 0.5,
                  ),
                ),
                SizedBox(height: 6),
                Text(
                  text,
                  style: TextStyle(
                    fontSize: 24,
                    fontWeight: FontWeight.bold,
                    color: colorScheme.onPrimary,
                  ),
                ),
              ],
            ),
            CircleAvatar(
              radius: 32,
              backgroundColor: colorScheme.onPrimary,
              child: Icon(Icons.person, color: colorScheme.secondary, size: 36),
            ),
          ],
        ),
      ),
    );
  }
}
